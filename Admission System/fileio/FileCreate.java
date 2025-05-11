import java.io.*;

public class FileCreate
{
    public static void main (String args[])
    { 
        try
         {
                 File file=new File("file.txt");
                 file.createNewFile();
          }
           catch(Exception e)
           {
                 System.out.println("Exception file not created"+e);
            }
    }

}