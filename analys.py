import sys
import MySQLdb
import pandas as pd
from PyQt6 import QtWidgets
import matplotlib.pyplot as plt
from matplotlib.backends.backend_qt5agg import FigureCanvasQTAgg as FigureCanvas

class Teacher:
    def __init__(self, first, last):
        self.first = first
        self.last = last

class Subject:
    def __init__(self, name):
        self.name = name

class Load:
    def __init__(self, teacher):
        self.teacher = teacher
        self.subjects = {}

    def add_subject(self, subject):
        self.subjects[subject.name] = self.subjects.get(subject.name, 0) + 1

class Journal:
    def __init__(self):
        self.loads = {}

    def add_lesson(self, teacher, subject):
        if teacher not in self.loads:
            self.loads[teacher] = Load(teacher)
        self.loads[teacher].add_subject(subject)

    def get_chart_data(self):
        data = {}
        for load in self.loads.values():
            for subj_name, count in load.subjects.items():
                key = f"{load.teacher.first} {load.teacher.last} - {subj_name}"
                data[key] = data.get(key, 0) + count
        return data

def fetch_lessons():
    with MySQLdb.connect("localhost", "root", "", "school") as conn:
        cursor = conn.cursor()
        cursor.execute("""
            SELECT teachers.first_name, teachers.last_name, subjects.name
            FROM lessons
            JOIN subjects ON lessons.subject_id = subjects.id
            JOIN teachers ON subjects.teacher_id = teachers.id""")
        lessons = cursor.fetchall()

    journal = Journal()
    for first, last, subj_name in lessons:
        journal.add_lesson(Teacher(first, last), Subject(subj_name))
    return journal

class MainWin(QtWidgets.QMainWindow):
    def __init__(self):
        super().__init__()
        self.figure = plt.Figure()
        self.canvas = FigureCanvas(self.figure)
        self.setCentralWidget(self.canvas)
        self.plot_data()

    def plot_data(self):
        journal = fetch_lessons()
        chart_data = journal.get_chart_data()
        subjects = list(chart_data.keys())
        counts = list(chart_data.values())

        self.figure.clear()
        ax = self.figure.add_subplot(111)
        ax.barh(subjects, counts)
        ax.set_xlabel("Номер урока")
        ax.set_ylabel("Учитель предмет")
        ax.set_title("Учитель для предмета")
        self.canvas.draw()

def main():
    app = QtWidgets.QApplication(sys.argv)
    window = MainWin()
    window.setWindowTitle("Lesson Journal")
    window.resize(1500, 600)
    window.show()
    sys.exit(app.exec())

if __name__ == '__main__':
    main()
