create database e_exam; 
use e_exam
create table padmin (
admin_id int,
admin_name varchar(50),
admin_address varchar(50),
admin_phone int
)
create table professor (
pro_id int ,
pro_name varchar(50),
pro_address varchar(50),
pro_phone int,
pro_courses varchar(50)
)
create table student (
s_id int ,
s_ssid int,
s_name varchar(50),
s_address varchar(50),
s_phone int,
s_department varchar(50),
s_pass varchar(50)
)
create table department (
dep_id int ,
dep_name varchar(50),
dep_corses varchar(50),
dep_profesor varchar(50),


)
create table course (
course_id int ,
course_name varchar(50),
department_id int,
prof_id int
)
create table exam (
exam_id int,
exam_password varchar(50),
exam_duration varchar(50),
s_id int ,
c_id int,
d_id int,
profe_id int
)
use e_exam
create table levels (
level_id int ,
number int,
student_id int
)

 create table questions (
 question_id int,
 exam_id int,
 catagory varchar(50),
 chapter_id int
 )
 create table question_mcq (
 question_id int,
 exam_id int,
 Q_A varchar(50),
 Q_B varchar(50),
 Q_c varchar(50),
 Q_d varchar(50)
 )
  create table question_TF (
 question_id int,
 exam_id int,
 Is_True bit,
 Is_False bit
 )
 create table answers (
 answer_id int,
 exam_id int,
 catagory varchar(50)
 )
 create table answer_mcq (
 question_id int,
 exam_id int,
 A_A varchar(50),
 A_B varchar(50),
 A_c varchar(50)
 )
 create table answer_TF (
 question_id int,
 exam_id int,
 TRUE varchar(50),
 FALSE varchar(50)
 )
 create table chapters (
 chapter_id int,
 course_id int,
 question_id int,
 number int
 )
 use e_exam
 create table Exam_Student (
 exam_id int,
 student_id int,
 examination_date datetime
 )
 create table course_Student (
 course_id int,
 student_id int,
 )
 create table department_professor (
 department_id int,
 professor_id int,
 )
 create table level_professor (
 level_id int,
 professor_id int,
 )
 create table department_level (
 department_id int,
 level_id int,
 )
 create table studnt_professor (
 student_id int,
 professor_id int,
 )
 create table course_professor (
 course_id int,
 professor_id int,
 )
 create table course_department (
 course_id int,
 department_id int,
 )

 


 

