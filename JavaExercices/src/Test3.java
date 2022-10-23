import java.util.*;



class Sir 
{
	String cuvant;
	
	public void setare_sir()
	{
		Scanner input = new Scanner(System.in);
		
		System.out.println("Dati un cuvant");
		cuvant=input.nextLine();
		
	    for(int i=0;i<cuvant.length();i++)
	    {
	    	if(cuvant.charAt(i)==' ')
	    	{
	    		System.out.println("Carcter neadecvat");
	    		System.exit(0);
	    	}else
	    	{
	    		if(cuvant.charAt(i)!=' ')
	    		{
	    		 continue;
	    		}
	    	}
	    }
		
	}
	
	public void afisare_sir()
	{
		System.out.println("Cuvantul este:"+cuvant);
	}
	
	public void afisare_lungime()
	{
		System.out.println("Lungimea cuvantului este:"+cuvant.length());
	}
	
	
	
	public void afisare_primulcaracter()
	{
		System.out.println("Primul caracter este:"+cuvant.charAt(0));
	}
	
	public void afisare_ultimcaracter()
	{
		System.out.println("Ultimul caracter este:"+cuvant.charAt(cuvant.length()-1));
	}
	
	public void afisare_carcateruldinmijloc()
	{
		System.out.println("Caracterul din mijloc este:"+cuvant.charAt(cuvant.length()/2));
	}
	
	public void afisare_vocale()
	{
		int count =  0;
		
		for(int i=0;i<cuvant.length();i++)
		{
			char c= cuvant.charAt(i);
			
			if(c=='a' || c=='e' || c=='i' || c=='o' || c=='u')
			{
				count++;
			}
		}
		System.out.println("Numarul de vocale din cuvant este:"+count);
	}
	
	public void afisare_consoane()
	{
		int count =0;
		
		for(int i=0;i<cuvant.length();i++)
		{
			char c = cuvant.charAt(i);
			
			if(c=='b' || c=='c' || c=='d' || c=='f' || c=='g' || c=='h' || c=='j' || c=='k' || c=='l' || c=='m' || c=='n' || c=='p' || c=='q' || c=='r' || c=='s')
			{
				count++;
			}
		}
		
		System.out.println("Numarul de consoane din cuvant este:"+count);
		
	}
	
	
	

}

public class Test3 {

	public static void main(String[] args) 
	{
		Sir ob = new Sir();
		
		ob.setare_sir();
		ob.afisare_sir();
		ob.afisare_lungime();
		ob.afisare_primulcaracter();
		ob.afisare_ultimcaracter();
		ob.afisare_carcateruldinmijloc();
		ob.afisare_vocale();
		ob.afisare_consoane();

	}

}
