package  classes;
import java.lang.*;
import interfaces.*;

public class Form
{
	 Student student[] = new Student [1000];
	
	public void insertStudent(Student s)
	{
		int x = 0;
		for(int i=0; i<student.length; i++)
		{
			if(student[i] == null)
			{
				student[i] = s;
				x = 1;
				break;
			}
		}
		if(x == 1)
		{
			System.out.println("Student Inserted");
		}
		else
		{
			System.out.println("Can Not Insert");
		}
	}
	
	public void removeStudent(Student s)
	{
		int x = 0;
		for(int i=0; i<student.length; i++)
		{
			if(student[i] == s)
			{
				student[i] = null;
				x = 1;
				break;
			}
		}
		if(x == 1){System.out.println("Student Removed");}
		else{System.out.println("Can Not Remove");}
	}





	public void showAllStudentForm()
	{
		for(Student s : student)
		{
			if(s != null)
			{
				System.out.println("**********************************");
				System.out.println("Student Name:           "+ s.getName());
				System.out.println("Student DOB:             "+ s.getDOB());
				System.out.println("Student Registation:  "+ s.getRegi());
				System.out.println("Student Roll:               "+ s.getRoll());
				System.out.println("Student Dep:               "+ s.getDep());
				System.out.println("----------------------------------");
				System.out.println("----------------------------------");
			}
		}
	}
	public Student getStudent(String regi)
	{
		Student s = null;
		
		for(int i=0; i<student.length; i++)
		{
			if(student[i] != null)
			{
				if(student[i].getRegi() == regi)
				{
					s = student[i];
					break;
				}
			}
		}
		if(s != null)
		{
			System.out.println("Student Found");
		}
		else
		{
			System.out.println("Student Not Found");
		}
		return s;
	}
}

	