package interfaces;
import java .io.*;
public interface StudentOpatation
{
	void insertStudent(Student s);
	void removeStudent(Student s);
	Customer getStudent(String regi);
	void showAllStudent();
}