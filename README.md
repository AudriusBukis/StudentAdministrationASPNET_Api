# StudentAdministrationASPNET_Api

.net 6 core The result of the work program code files and database script in file 'StudentAdministrationDB_CreateFile.sql'

NuGet pacages was used

Microsoft.EntityFrameworkCore version 6.0.8
Microsoft.EntityFrameworkCore.SqlServer version 6.0.8
Microsoft.EntityFrameworkCore.Tools version 6.0.8

Task diskription

The task is to create a simplified model of student administration in higher education.
The student administration system must keep track of study programs and subjects, study program
structure, students and student enrollments in a particular higher education institution.
A higher education institution can have multiple study programs they teach.
Each study program is composed of multiple subjects. Each subject can be composed of multiple sub 
subjects and this structure could continue indefinitely into the depth.
Each study program and subject have unique code, name and credits.
Students can enroll to a particular study program every year. Student can only have one active 
enrollment at a time at the same institution.
