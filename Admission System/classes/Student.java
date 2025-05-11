package  classes;
import java.lang.*;
import interfaces.*;

public class Student
{
	private String name;
	private String DOB;
	private String regi;
	private String roll;
	private String dep;

	public void setName(String name){this.name = name;}
	public void setDOB(String DOB){this.DOB = DOB;}
	public void setRegi(String regi){this.regi = regi;}
	public void setRoll(String roll){this.roll = roll;}
	public void setDep(String dep){this.dep = dep;}
	
	public String getName(){return name;}
	public String getDOB(){return DOB;}
	public String getRegi(){return regi;}
	public String getRoll(){return roll;}
	public String getDep(){return dep;}
	
}