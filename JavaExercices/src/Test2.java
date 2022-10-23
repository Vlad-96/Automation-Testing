import java.util.*;



class Student
{
	String firstname,lastname;
	int age,andestudiu;
	
	
	public void setare_date()
	{
		Scanner input = new Scanner(System.in);
		
		System.out.print("Dati un nume:");
		firstname = input.nextLine();
		
		System.out.print("Dati un prenume:");
		lastname = input.nextLine();
		
		System.out.print("Dati o varsta:");
		age = input.nextInt();
		
		if(age> 18)
		{
			System.out.println("Varsta adecvata");
		}else
		{
			if(age<18) {
				System.exit(0);
			}
		}
		
		System.out.print("Dati un an de studiu:");
		andestudiu= input.nextInt();
		
		if(andestudiu <7 && andestudiu >0)
		{
			System.out.println("Anul de studiu este adecvat");
		}else
		{
			if(andestudiu > 7)
			{
				System.exit(0);
			}
		}
		
	}
	
	public void afisare_date()
	{
		System.out.println("Nume studentului este: "+firstname);
		System.out.println("Prenumele studentului este: "+lastname);
		System.out.println("Varsta studentului este: "+age);
		System.out.println("Anul de studiu al studentului este: "+andestudiu);
	}
	

	
	
}


public class Test2 {

	public static void main(String[] args) 
	{
       
		Student s1 = new Student();
		
		s1.setare_date();
		s1.afisare_date();
     
	}

}
