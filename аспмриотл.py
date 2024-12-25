import sys
import MySQLdb
import pandas as pd
from PyQt6 import QtWidgets
from lesson_journal import Ui_Form
class Teacher:
    def __init__(self, first_name, last_name):
        self.first_name = first_name
        self.last_name = last_name
class Subject:
    def __init__(self, name):
        self.name = name
class TeacherLoad:
    def __init__(self, teacher):
        self.teacher = teacher
        self.subjects = {}
    def add_subject(self, subject):
        self.subjects[subject.name] = self.subjects.get(subject.name, 0) + 1
class LessonJournal:
    def __init__(self):
        self.teachers_load = {}

    def add_lesson(self, teacher, subject):
        if teacher not in self.teachers_load:
            self.teachers_load[teacher] = TeacherLoad(teacher)
        self.teachers_load[teacher].add_subject(subject)

    def export_to_excel(self, file):
        data = {
            'first_name': [],
            'last_name': [],
            'subject': [],
            'count': []
        }
        for teacher_load in self.teachers_load.values():
            for subject_name, count in teacher_load.subjects.items():
                data['first_name'].append(teacher_load.teacher.first_name)
                data['last_name'].append(teacher_load.teacher.last_name)
                data['subject'].append(subject_name)
                data['count'].append(count)

        df = pd.DataFrame(data)
        summary = df.groupby(['first_name', 'last_name', 'subject']).sum().reset_index()
        summary.to_excel(file, index=False)
        return f'Data exported to {file}'
def fetch_lessons():
    connect = MySQLdb.connect("localhost", "root", "", "school")
    cursor = connect.cursor()
    cursor.execute("""
        SELECT teachers.first_name, teachers.last_name, subjects.name
        FROM lessons
        JOIN subjects ON lessons.subject_id = subjects.id
        JOIN teachers ON subjects.teacher_id = teachers.id""")
    lessons = cursor.fetchall()
    journal = LessonJournal()

    for first_name, last_name, subject_name in lessons:
        teacher = Teacher(first_name, last_name)
        subject = Subject(subject_name)
        journal.add_lesson(teacher, subject)

    cursor.close()
    connect.close()
    return journal
class MainWindow(QtWidgets.QMainWindow):
    def __init__(self):
        super(MainWindow, self).__init__()
        self.ui = Ui_Form()
        self.ui.setupUi(self)
        self.ui.exportButton.clicked.connect(self.export_data)
    def export_data(self):
        journal = fetch_lessons()
        message = journal.export_to_excel("teacher_load_reportyhvib.xlsx")
        QtWidgets.QMessageBox.information(self, "Export Complete", message)
def main():
    app = QtWidgets.QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())

if __name__ == '__main__':
    main()
