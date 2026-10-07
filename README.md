#StudyTrack
##Project Description

StudyTrack is a basic program created with C# and windows forms. StudyTrack allows the user to keep all of their subjects and tasks they need to do in one location. Rather than having them all spread out. 

User can be able to add subject to the application, they can also add tasks to each subject and give them a due date. User will be able to select priority and task type as well. User can check of tasks and delete them. All information will be saved locally through the use of JSON files when user closes the application.

Main Features

Add and manage subjects
Add tasks linked to subjects
Select task due dates
Set task priority
Select task type such as Assignment, Quiz, Exam or Reading
Mark tasks as complete
Delete tasks with confirmation
Automatically link a selected subject to the task subject
Save and load subjects and tasks using JSON
Validate user input and display error messages


OOP Design

It shows most of the OOP concepts that we learned throughout this unit. 
Classes: Our application has many classes including Subject Task and JsonStorageService.
Encapsulation: Private fields and public properties are used in our Subject and StudyTaskBase classes.
Inheritance: We have multiple classes that inherit from our StudyTaskBase class. AssignmentTask QuizTask ExamTask and ReadingTask all inherit from StudyTaskBase.
Polymorphism: Each of our Tasks can override the GetTaskDescription() method.
Abstraction: StudyTaskBase is an abstract class that allows us to create generic information about a task and can be inherited by other classes.
Exceptions: We use try catch statements to help our application from failing if any exceptions occur.

Data Storage
StudyTrack uses JSON file-based storage rather than a database.

It will create a data folder that will hold:
subjects.json - Information about subjects 
tasks.json - Information about tasks 

These json files will be read at the start of the application and modified if any subjects or tasks are modified.

How to Run
Once you have opened the StudyTrack.sln file in visual studio.

Ensure our project is up to date and can be built.
Go to Build -> Build Solution to build your solution.
Can run our application by clicking the green StudyTrack button in Visual Studio.
Making sure to add a subject before adding a task.
Choose a subject and add tasks to that subject by using the task input.

The application does not need an outside database as we are using json files.

Setup 

Program was created using the following 

C# 

.Net 

Windows forms 

Microsoft visual studio 

Git and Github 

We will need Windows and the .Net development pack.
References and tools used 

Microsoft Visual studio to create the application in C# and Windows forms.

Git to use version control. 

GitHub to store my development history. 

Microsoft references and courses to help with my knowledge on C# and Windows forms.

I used ChatGPT as a learning aid to better understand C#. It helped me with errors and to learn how to make my interface look better. I was also able to ask questions on what i could do to achieve my goal. I have understood the application I have created.
