using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
	
    public class DbInitialzer:DropCreateDatabaseAlways<UniversityContext>
    {
        protected  override void Seed (UniversityContext context){
		University univ = new University {Id = 1, Name = "National University of Ivan Franko", Address = "Lviv, sichovih strilciv 1"};
		
			Faculty fac = new Faculty {Id = 1, Name = "Applied Mathematics and Informatics", UniversityId = 1, University = univ};
			
				Group gr = new Group {Id = 1, Name = "System analysis 42", FacultyId = 1, Faculty = fac };

                Student st1 = new Student { Id = 1, Name = "Andriy", SurName = "Buy", GroupId = 1, StudentBookNumber = "12121212" };
                Student st2 = new Student { Id = 2, Name = "Andriy", SurName = "Vercimaga", GroupId = 1, StudentBookNumber = "11111113" };
                Student st3 = new Student { Id = 3, Name = "Andriy", SurName = "Vengrunovuch", GroupId = 1, StudentBookNumber = "11111114" };
                Student st4 = new Student { Id = 4, Name = "Taras", SurName = "Viter", GroupId = 1, StudentBookNumber = "11111115" };
                Student st5 = new Student { Id = 5, Name = "Rostuslav", SurName = "Dembickuy", GroupId = 1, StudentBookNumber = "11111116" };
                Student st6 = new Student { Id = 6, Name = "Andriy", SurName = "Derdzyak", GroupId = 1, StudentBookNumber = "11111117" };
                Student st7 = new Student { Id = 7, Name = "Orest", SurName = "Gurskuy", GroupId = 1, StudentBookNumber = "11111118" };
                Student st8 = new Student { Id = 8, Name = "Mykola", SurName = "Zubekhin", GroupId = 1, StudentBookNumber = "11111119" };
                Student st9 = new Student { Id = 9, Name = "Maryan", SurName = "Kalapach", GroupId = 1, StudentBookNumber = "11111110" };
                Student st10 = new Student { Id = 10, Name = "Bogdan", SurName = "Kovalchuk", GroupId = 1, StudentBookNumber = "11111111" };
                Student st11 = new Student { Id = 11, Name = "Maryan", SurName = "Onusko", GroupId = 1, StudentBookNumber = "11111112" };
                Student st12 = new Student { Id = 12, Name = "Taras", SurName = "Savitskuy", GroupId = 1, StudentBookNumber = "11111122" };
                Student st13 = new Student { Id = 13, Name = "Bogdan", SurName = "Ystyak", GroupId = 1, StudentBookNumber = "11111123" };
                Student st14 = new Student { Id = 14, Name = "Nastya", SurName = "Sokolova", GroupId = 1, StudentBookNumber = "111111135" };
                Student st15 = new Student { Id = 15, Name = "Ivan", SurName = "Fedushun", GroupId = 1, StudentBookNumber = "111111137" };
                Student st16 = new Student { Id = 16, Name = "Bogdan", SurName = "Polidovuch", GroupId = 1, StudentBookNumber = "111111136" };
                Student st17 = new Student { Id = 17, Name = "Khristina", SurName = "Pochunok", GroupId = 1, StudentBookNumber = "111111139" };
                Student st18 = new Student { Id = 18, Name = "Orest-Andriy", SurName = "Senkiv", GroupId = 1, StudentBookNumber = "111111138" };
                Student st19 = new Student { Id = 19, Name = "Oleg", SurName = "Yackiv", GroupId = 1, StudentBookNumber = "111111131" };
                Student st20 = new Student { Id = 20, Name = "Roman", SurName = "Melnuk", GroupId = 1, StudentBookNumber = "111111132" };
					
					Subject s1 = new Subject {Id = 1, Name = "Informatic", Students = new List<Student>() { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17, st18, st19, st20 }};
					Subject s2 = new Subject {Id = 2, Name = "DataBase",Students = new List<Student>() { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17, st18, st19, st20 }};
					Subject s3 = new Subject {Id = 3, Name = "Web Design", Students = new List<Student>() { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17, st18, st19, st20 }};
					Subject s4 = new Subject {Id = 4, Name = "History", Students = new List<Student>() { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17, st18, st19, st20 }};
					Subject s5 = new Subject {Id = 5, Name = "Web Programming", Students = new List<Student>() { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17, st18, st19, st20 }};
					Subject s6 = new Subject {Id = 6, Name = "OOP. C++", Students = new List<Student>() { st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17, st18, st19, st20 }};
					
					Lector l1 = new Lector {Id = 1, Name = "Andiy", SurName = "Korkyna", Grade = "Aspirant", Subjects = new List<Subject>() {s1, s2}};
					Lector l2 = new Lector {Id = 2, Name = "Lesya", SurName = "Fundak", Grade = "Docent", Subjects = new List<Subject>() {s1, s6}};
					Lector l3 = new Lector {Id = 3, Name = "Frodo", SurName = "Torbins", Grade = "Hobbit", Subjects = new List<Subject>() {s4}};
					Lector l4 = new Lector {Id = 4, Name = "Lesya", SurName = "Dobulyak", Grade = "Docent", Subjects = new List<Subject>() {s3,s5}};
					
					MarkPoint mp1 = new MarkPoint {Id = 1, Name = "Module1", maxValue = 10, SubjectId = 1 };
					MarkPoint mp2 = new MarkPoint {Id = 2, Name = "Module2", maxValue = 10, SubjectId = 1  };
					MarkPoint mp3 = new MarkPoint {Id = 3, Name = "HomeWork.Theme1", maxValue = 15, SubjectId = 1 };
					MarkPoint mp4 = new MarkPoint {Id = 4, Name = "Module3", maxValue = 15, SubjectId = 1 };
					MarkPoint mp5 = new MarkPoint {Id = 5, Name = "Exam", maxValue = 50, SubjectId = 1 };
					
					MarkPoint mp21 = new MarkPoint {Id = 6, Name = "Module1", maxValue = 25, SubjectId = 2  };
					MarkPoint mp22 = new MarkPoint {Id = 7, Name = "Module2", maxValue = 25, SubjectId = 2 };
					MarkPoint mp23 = new MarkPoint {Id = 8, Name = "Exam", maxValue = 50, SubjectId = 2  };
					
					MarkPoint mp31 = new MarkPoint {Id = 9, Name = "CustomProject.1", maxValue = 5, SubjectId =3  };
					MarkPoint mp32 = new MarkPoint {Id = 10, Name = "CustomProject.2", maxValue = 5, SubjectId =3  };
					MarkPoint mp33 = new MarkPoint {Id = 11, Name = "CustomProject.3", maxValue = 5, SubjectId =3  };
					MarkPoint mp34 = new MarkPoint {Id = 12, Name = "CustomProject.4", maxValue = 5, SubjectId =3  };
					MarkPoint mp35 = new MarkPoint {Id = 13, Name = "CustomProject.5", maxValue = 5, SubjectId =3  };
					MarkPoint mp36 = new MarkPoint {Id = 14, Name = "CustomProject.6", maxValue = 5, SubjectId =3 };
					MarkPoint mp37 = new MarkPoint {Id = 15, Name = "CustomProject.7", maxValue = 5, SubjectId =3  };
					MarkPoint mp38 = new MarkPoint {Id = 16, Name = "CustomProject.8", maxValue = 5, SubjectId =3  };
					MarkPoint mp39 = new MarkPoint {Id = 17, Name = "CustomProject.9", maxValue = 5, SubjectId =3 };
					MarkPoint mp310 = new MarkPoint {Id = 18, Name = "CustomProject.10", maxValue = 5, SubjectId =3 };
					MarkPoint mp311 = new MarkPoint {Id = 19, Name = "Exam", maxValue = 50, SubjectId =3 };
					
					MarkPoint mp41 = new MarkPoint {Id = 20, Name = "Test.1", maxValue = 10, SubjectId =4};
					MarkPoint mp42 = new MarkPoint {Id = 21, Name = "Test.2", maxValue = 10, SubjectId =4 };
					MarkPoint mp43 = new MarkPoint {Id = 22, Name = "Test.3", maxValue = 10, SubjectId =4 };
					MarkPoint mp44 = new MarkPoint {Id = 23, Name = "Test.4", maxValue = 10, SubjectId =4 };
					MarkPoint mp45 = new MarkPoint {Id = 24, Name = "Test.5", maxValue = 10, SubjectId =4 };
					MarkPoint mp46 = new MarkPoint {Id = 25, Name = "Exam", maxValue = 50, SubjectId =4 };
					
					MarkPoint mp51 = new MarkPoint {Id = 26, Name = "Module1", maxValue = 10, SubjectId =5 };
					MarkPoint mp52 = new MarkPoint {Id = 27, Name = "Module2", maxValue = 10, SubjectId =5 };
					MarkPoint mp53 = new MarkPoint {Id = 28, Name = "CustomDataBase", maxValue = 30, SubjectId =5 };
					MarkPoint mp54 = new MarkPoint {Id = 29, Name = "Exam", maxValue = 50, SubjectId =5 };
					
					MarkPoint mp61 = new MarkPoint {Id = 30, Name = "Task1", maxValue = 5, SubjectId =6 };
					MarkPoint mp62 = new MarkPoint {Id = 31, Name = "Task2", maxValue = 15, SubjectId =6 };
					MarkPoint mp63 = new MarkPoint {Id = 32, Name = "Task3", maxValue = 20, SubjectId =6 };
					MarkPoint mp64 = new MarkPoint {Id = 33, Name = "Task4", maxValue = 15, SubjectId =6 };
					MarkPoint mp65 = new MarkPoint {Id = 34, Name = "Task5", maxValue = 10, SubjectId =6 };
					MarkPoint mp66 = new MarkPoint {Id = 35, Name = "Task6", maxValue = 15, SubjectId =6 };
					MarkPoint mp67 = new MarkPoint {Id = 36, Name = "Task7", maxValue = 5, SubjectId =6 };
					MarkPoint mp68 = new MarkPoint {Id = 37, Name = "Task8", maxValue = 15, SubjectId =6 };
					
					Mark m11 = new Mark {Id = 1, Value = 5, MarkPointId = 1, StudentId = 1  };
					Mark m21 = new Mark {Id = 2, Value = 3, MarkPointId = 2, StudentId = 1  }; 
					Mark m31 = new Mark {Id = 3, Value = 10, MarkPointId = 3, StudentId = 1  }; 
					Mark m41 = new Mark {Id = 4, Value = 10, MarkPointId = 4, StudentId = 1  }; 
					Mark m51 = new Mark {Id = 5, Value = 33, MarkPointId = 5, StudentId = 1  };
					
					Mark m211 = new Mark {Id = 6, Value = 12, MarkPointId = 6, StudentId = 1  }; 
					Mark m221 = new Mark {Id = 7, Value = 20, MarkPointId = 7, StudentId = 1  }; 
					Mark m231 = new Mark {Id = 8, Value = 31, MarkPointId = 8, StudentId = 1 };
					
					Mark m311 = new Mark {Id = 9, Value =4 , MarkPointId = 9, StudentId = 1};
					Mark m321 = new Mark {Id = 10, Value =3 , MarkPointId = 10, StudentId = 1};
					Mark m331 = new Mark {Id = 11, Value =0 , MarkPointId = 11, StudentId = 1};
					Mark m341 = new Mark {Id = 12, Value =4 , MarkPointId = 12, StudentId = 1};
					Mark m351 = new Mark {Id = 13, Value =2 , MarkPointId = 13, StudentId = 1};
					Mark m361 = new Mark {Id = 14, Value =5 , MarkPointId = 14, StudentId = 1};
					Mark m371 = new Mark {Id = 15, Value =5 , MarkPointId = 15, StudentId = 1};
					Mark m381 = new Mark {Id = 16, Value =4 , MarkPointId = 16, StudentId = 1};
					Mark m391 = new Mark {Id = 17, Value =3 , MarkPointId = 17, StudentId = 1};
					Mark m3101 = new Mark {Id = 18, Value =5 , MarkPointId = 18, StudentId = 1};
					Mark m3111 = new Mark {Id = 19, Value =32 , MarkPointId = 19, StudentId = 1};
					
					Mark m411 = new Mark {Id = 20, Value =8 , MarkPointId = 20, StudentId = 1};
					Mark m421 = new Mark {Id = 21, Value =10 , MarkPointId = 21, StudentId = 1};
					Mark m431 = new Mark {Id = 22, Value =10 , MarkPointId = 22, StudentId = 1};
					Mark m441 = new Mark {Id = 23, Value =9 , MarkPointId = 23, StudentId = 1};
					Mark m451 = new Mark {Id = 24, Value =8 , MarkPointId = 24, StudentId = 1};
					Mark m461 = new Mark {Id = 25, Value =45 , MarkPointId = 25, StudentId = 1};
					
					Mark m511 = new Mark {Id = 26, Value =10 , MarkPointId = 26, StudentId = 1};
					Mark m521 = new Mark {Id = 27, Value =10 , MarkPointId = 27, StudentId = 1};
					Mark m531 = new Mark {Id = 28, Value =15 , MarkPointId = 28, StudentId = 1};
					Mark m541 = new Mark {Id = 29, Value =30 , MarkPointId = 29, StudentId = 1};
					
					Mark m611 = new Mark {Id = 30, Value =0 , MarkPointId = 30, StudentId = 1};
					Mark m621 = new Mark {Id = 31, Value =10 , MarkPointId = 31, StudentId = 1};
					Mark m631 = new Mark {Id = 32, Value =13 , MarkPointId = 32, StudentId = 1};
					Mark m641 = new Mark {Id = 33, Value =12 , MarkPointId = 33, StudentId = 1};
					Mark m651 = new Mark {Id = 34, Value =5 , MarkPointId = 34, StudentId = 1};
					Mark m661 = new Mark {Id = 35, Value =13 , MarkPointId = 35, StudentId = 1};
					Mark m671 = new Mark {Id = 36, Value =1 , MarkPointId = 36, StudentId = 1};
					Mark m681 = new Mark {Id = 37, Value =10 , MarkPointId = 37, StudentId = 1};
					
					Mark m12 = new Mark {Id = 38, Value = 9, MarkPointId = 1, StudentId = 2  };
					Mark m22 = new Mark {Id = 39, Value = 5, MarkPointId = 2, StudentId = 2  }; 
					Mark m32 = new Mark {Id = 40, Value = 15, MarkPointId = 3, StudentId = 2  }; 
					Mark m42 = new Mark {Id = 41, Value = 12, MarkPointId = 4, StudentId = 2  }; 
					Mark m52 = new Mark {Id = 42, Value = 43, MarkPointId = 5, StudentId = 2  };
					
					Mark m212 = new Mark {Id = 43, Value = 25, MarkPointId = 6, StudentId = 2  }; 
					Mark m222 = new Mark {Id = 44, Value = 22, MarkPointId = 7, StudentId = 2  }; 
					Mark m232 = new Mark {Id = 45, Value = 49, MarkPointId = 8, StudentId = 2 };
					
					Mark m312 = new Mark {Id = 46, Value =5 , MarkPointId = 9, StudentId = 2};
					Mark m322 = new Mark {Id = 47, Value =5 , MarkPointId = 10, StudentId = 2};
					Mark m332 = new Mark {Id = 48, Value =5 , MarkPointId = 11, StudentId = 2};
					Mark m342 = new Mark {Id = 49, Value =5 , MarkPointId = 12, StudentId = 2};
					Mark m352 = new Mark {Id = 50, Value =5 , MarkPointId = 13, StudentId = 2};
					Mark m362 = new Mark {Id = 51, Value =5 , MarkPointId = 14, StudentId = 2};
					Mark m372 = new Mark {Id = 52, Value =5 , MarkPointId = 15, StudentId = 2};
					Mark m382 = new Mark {Id = 53, Value =5 , MarkPointId = 16, StudentId = 2};
					Mark m392 = new Mark {Id = 54, Value =5 , MarkPointId = 17, StudentId = 2};
					Mark m3102 = new Mark {Id = 55, Value =5 , MarkPointId = 18, StudentId = 2};
					Mark m3112 = new Mark {Id = 56, Value =50 , MarkPointId = 19, StudentId = 2};
					
					Mark m412 = new Mark {Id = 57, Value =10 , MarkPointId = 20, StudentId = 2};
					Mark m422 = new Mark {Id = 58, Value =9 , MarkPointId = 21, StudentId = 2};
					Mark m432 = new Mark {Id = 59, Value =9 , MarkPointId = 22, StudentId = 2};
					Mark m442 = new Mark {Id = 60, Value =10 , MarkPointId = 23, StudentId = 2};
					Mark m452 = new Mark {Id = 61, Value =7 , MarkPointId = 24, StudentId = 2};
					Mark m462 = new Mark {Id = 62, Value =47 , MarkPointId = 25, StudentId = 2};
				
					Mark m512 = new Mark {Id = 63, Value =5 , MarkPointId = 26, StudentId = 2};
					Mark m522 = new Mark {Id = 64, Value =8 , MarkPointId = 27, StudentId = 2};
					Mark m532 = new Mark {Id = 65, Value =28 , MarkPointId = 28, StudentId = 2};
					Mark m542 = new Mark {Id = 66, Value =39 , MarkPointId = 29, StudentId = 2};
					
					Mark m612 = new Mark {Id = 67, Value =5 , MarkPointId = 30, StudentId = 2};
					Mark m622 = new Mark {Id = 68, Value =15 , MarkPointId = 31, StudentId = 2};
					Mark m632 = new Mark {Id = 69, Value =20 , MarkPointId = 32, StudentId = 2};
					Mark m642 = new Mark {Id = 70, Value =15 , MarkPointId = 33, StudentId = 2};
					Mark m652 = new Mark {Id = 71, Value =10 , MarkPointId = 34, StudentId = 2};
					Mark m662 = new Mark {Id = 72, Value =15 , MarkPointId = 35, StudentId = 2};
					Mark m672 = new Mark {Id = 73, Value =5 , MarkPointId = 36, StudentId = 2};
					Mark m682 = new Mark {Id = 74, Value =15 , MarkPointId = 37, StudentId = 2};
					
					Mark m13 = new Mark {Id = 75, Value = 7, MarkPointId = 1, StudentId = 3  };
					Mark m23 = new Mark {Id = 76, Value = 3, MarkPointId = 2, StudentId = 3  }; 
					Mark m33 = new Mark {Id = 77, Value = 8, MarkPointId = 3, StudentId = 3  }; 
					Mark m43 = new Mark {Id = 78, Value = 12, MarkPointId = 4, StudentId = 3  }; 
					Mark m53 = new Mark {Id = 79, Value = 35, MarkPointId = 5, StudentId = 3 };
					
					Mark m213 = new Mark {Id = 80, Value = 20, MarkPointId = 6, StudentId = 3  }; 
					Mark m223 = new Mark {Id = 81, Value = 21, MarkPointId = 7, StudentId = 3  }; 
					Mark m233 = new Mark {Id = 82, Value = 40, MarkPointId = 8, StudentId = 3 };
					
					Mark m313 = new Mark {Id = 83, Value =4 , MarkPointId = 9, StudentId = 3};
					Mark m323 = new Mark {Id = 84, Value =4 , MarkPointId = 10, StudentId = 3};
					Mark m333 = new Mark {Id = 85, Value =4 , MarkPointId = 11, StudentId = 3};
					Mark m343 = new Mark {Id = 86, Value =4 , MarkPointId = 12, StudentId = 3};
					Mark m353 = new Mark {Id = 87, Value =5 , MarkPointId = 13, StudentId = 3};
					Mark m363 = new Mark {Id = 88, Value =5 , MarkPointId = 14, StudentId = 3};
					Mark m373 = new Mark {Id = 89, Value =4 , MarkPointId = 15, StudentId = 3};
					Mark m383 = new Mark {Id = 90, Value =4 , MarkPointId = 16, StudentId = 3};
					Mark m393 = new Mark {Id = 91, Value =4 , MarkPointId = 17, StudentId = 3};
					Mark m3103 = new Mark {Id = 92, Value =3 , MarkPointId = 18, StudentId = 3};
					Mark m3113 = new Mark {Id = 93, Value =39 , MarkPointId = 19, StudentId = 3};
					
					Mark m413 = new Mark {Id = 94, Value =8 , MarkPointId = 20, StudentId = 3};
					Mark m423 = new Mark {Id = 95, Value =9 , MarkPointId = 21, StudentId = 3};
					Mark m433 = new Mark {Id = 96, Value =9 , MarkPointId = 22, StudentId = 3};
					Mark m443 = new Mark {Id = 97, Value =7 , MarkPointId = 23, StudentId = 3};
					Mark m453 = new Mark {Id = 98, Value =8 , MarkPointId = 24, StudentId = 3};
					Mark m463 = new Mark {Id = 99, Value =45 , MarkPointId = 25, StudentId = 3};
					
					Mark m513 = new Mark {Id = 100, Value =10 , MarkPointId = 26, StudentId = 3};
					Mark m523 = new Mark {Id = 101, Value =8 , MarkPointId = 27, StudentId = 3};
					Mark m533 = new Mark {Id = 102, Value =25 , MarkPointId = 28, StudentId = 3};
					Mark m543 = new Mark {Id = 103, Value =41 , MarkPointId = 29, StudentId = 3};
					
					Mark m613 = new Mark {Id = 104, Value =4 , MarkPointId = 30, StudentId = 3};
					Mark m623 = new Mark {Id = 105, Value =14 , MarkPointId = 31, StudentId = 3};
					Mark m633 = new Mark {Id = 106, Value =12 , MarkPointId = 32, StudentId = 3};
					Mark m643 = new Mark {Id = 107, Value =14 , MarkPointId = 33, StudentId = 3};
					Mark m653 = new Mark {Id = 108, Value =10 , MarkPointId = 34, StudentId = 3};
					Mark m663 = new Mark {Id = 109, Value =15 , MarkPointId = 35, StudentId = 3};
					Mark m673 = new Mark {Id = 110, Value =5 , MarkPointId = 36, StudentId = 3};
					Mark m683 = new Mark {Id = 111, Value =15 , MarkPointId = 37, StudentId = 3};

                    st1.setMark(new List<Mark>() { m11, m21, m31, m41, m51, m211, m221, m231, m311, m321, m331, m341, m351, m361, m371, m381, m391, m3101, m3111,
                                                    m411, m421, m431, m441, m451, m461, m511, m521, m531, m541, m611, m621, m631, m641, m651, m661, m671, m681});
                    st2.setMark(new List<Mark>() { m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682, m682 });
					
			context.University.Add(univ);
			context.Faculty.Add(fac);
			context.Group.Add(gr);
			
				context.Student.Add(st1);
				context.Student.Add(st2);
				context.Student.Add(st3);
				context.Student.Add(st4);
				context.Student.Add(st5);
				context.Student.Add(st6);
				context.Student.Add(st7);
				context.Student.Add(st8);
				context.Student.Add(st9);
				context.Student.Add(st10);	
				context.Student.Add(st11);
				context.Student.Add(st12);
				context.Student.Add(st13);
				context.Student.Add(st14);
				context.Student.Add(st15);	
				context.Student.Add(st16);
				context.Student.Add(st17);
				context.Student.Add(st18);
				context.Student.Add(st19);
				context.Student.Add(st20);
				
				context.Lector.Add(l1);
				context.Lector.Add(l2);
				context.Lector.Add(l3);
				context.Lector.Add(l4);
				
				context.Subject.Add(s1);
				context.Subject.Add(s2);
				context.Subject.Add(s3);
				context.Subject.Add(s4);
				context.Subject.Add(s5);
				context.Subject.Add(s6);
				
				context.MarkPoint.Add(mp1);
				context.MarkPoint.Add(mp2);
				context.MarkPoint.Add(mp3);
				context.MarkPoint.Add(mp4);
				context.MarkPoint.Add(mp5);
				
				context.MarkPoint.Add(mp21);
				context.MarkPoint.Add(mp22);
				context.MarkPoint.Add(mp23);
				
				context.MarkPoint.Add(mp31);
				context.MarkPoint.Add(mp32);
				context.MarkPoint.Add(mp33);
				context.MarkPoint.Add(mp34);
				context.MarkPoint.Add(mp35);
				context.MarkPoint.Add(mp36);
				context.MarkPoint.Add(mp37);
				context.MarkPoint.Add(mp38);
				context.MarkPoint.Add(mp39);
				context.MarkPoint.Add(mp310);
				context.MarkPoint.Add(mp311);
				
				context.MarkPoint.Add(mp41);
				context.MarkPoint.Add(mp42);
				context.MarkPoint.Add(mp43);
				context.MarkPoint.Add(mp44);
				context.MarkPoint.Add(mp45);
				context.MarkPoint.Add(mp46);
				
				context.MarkPoint.Add(mp51);
				context.MarkPoint.Add(mp52);
				context.MarkPoint.Add(mp53);
				context.MarkPoint.Add(mp54);
				
				context.MarkPoint.Add(mp61);
				context.MarkPoint.Add(mp62);
				context.MarkPoint.Add(mp63);
				context.MarkPoint.Add(mp64);
				context.MarkPoint.Add(mp65);
				context.MarkPoint.Add(mp66);
				context.MarkPoint.Add(mp67);
				context.MarkPoint.Add(mp68);
				
					context.Mark.Add(m11);
					context.Mark.Add(m21); 
					context.Mark.Add(m31);
					context.Mark.Add(m41); 
					context.Mark.Add(m51);
					
					context.Mark.Add(m211); 
					context.Mark.Add(m221);
					context.Mark.Add(m231);
					
					context.Mark.Add(m311);
					context.Mark.Add(m321);
					context.Mark.Add(m331);
					context.Mark.Add(m341);
					context.Mark.Add(m351);
					context.Mark.Add(m361);
					context.Mark.Add(m371);
					context.Mark.Add(m381);
					context.Mark.Add(m391);
					context.Mark.Add(m3101);
					context.Mark.Add(m3111);
					
					context.Mark.Add(m411);
					context.Mark.Add(m421);
					context.Mark.Add(m431);
					context.Mark.Add(m441);
					context.Mark.Add(m451);
					context.Mark.Add(m461);
					
					context.Mark.Add(m511);
					context.Mark.Add(m521);
					context.Mark.Add(m531);
					context.Mark.Add(m541);
					
					context.Mark.Add(m611);
					context.Mark.Add(m621);
					context.Mark.Add(m631);
					context.Mark.Add(m641);
					context.Mark.Add(m651);
					context.Mark.Add(m661);
					context.Mark.Add(m671);
					context.Mark.Add(m681);
					
					context.Mark.Add(m12);
					context.Mark.Add(m22); 
					context.Mark.Add(m32);
					context.Mark.Add(m42); 
					context.Mark.Add(m52);
					
					context.Mark.Add(m212); 
					context.Mark.Add(m222);
					context.Mark.Add(m232);
					
					context.Mark.Add(m312);
					context.Mark.Add(m322);
					context.Mark.Add(m332);
					context.Mark.Add(m342);
					context.Mark.Add(m352);
					context.Mark.Add(m362);
					context.Mark.Add(m372);
					context.Mark.Add(m382);
					context.Mark.Add(m392);
					context.Mark.Add(m3102);
					context.Mark.Add(m3112);
					
					context.Mark.Add(m412);
					context.Mark.Add(m422);
					context.Mark.Add(m432);
					context.Mark.Add(m442);
					context.Mark.Add(m452);
					context.Mark.Add(m462);
					
					context.Mark.Add(m512);
					context.Mark.Add(m522);
					context.Mark.Add(m532);
					context.Mark.Add(m542);
					
					context.Mark.Add(m612);
					context.Mark.Add(m622);
					context.Mark.Add(m632);
					context.Mark.Add(m642);
					context.Mark.Add(m652);
					context.Mark.Add(m662);
					context.Mark.Add(m672);
					context.Mark.Add(m682);
				
					context.Mark.Add(m13);
					context.Mark.Add(m23); 
					context.Mark.Add(m33);
					context.Mark.Add(m43); 
					context.Mark.Add(m53);
					
					context.Mark.Add(m213); 
					context.Mark.Add(m223);
					context.Mark.Add(m233);
					
					context.Mark.Add(m313);
					context.Mark.Add(m323);
					context.Mark.Add(m333);
					context.Mark.Add(m343);
					context.Mark.Add(m353);
					context.Mark.Add(m363);
					context.Mark.Add(m373);
					context.Mark.Add(m383);
					context.Mark.Add(m393);
					context.Mark.Add(m3103);
					context.Mark.Add(m3113);
					
					context.Mark.Add(m413);
					context.Mark.Add(m423);
					context.Mark.Add(m433);
					context.Mark.Add(m443);
					context.Mark.Add(m453);
					context.Mark.Add(m463);
					
					context.Mark.Add(m513);
					context.Mark.Add(m523);
					context.Mark.Add(m533);
					context.Mark.Add(m543);
					
					context.Mark.Add(m613);
					context.Mark.Add(m623);
					context.Mark.Add(m633);
					context.Mark.Add(m643);
					context.Mark.Add(m653);
					context.Mark.Add(m663);
					context.Mark.Add(m673);
					context.Mark.Add(m683);
				
					base.Seed(context);


    }
}
}
