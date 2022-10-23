import java.util.*;


class Sirul
{
	int sir []= {6,9,4,-7,-2,12,-5,-45,5};
	
	
	public void afisare_sir()
	{
		System.out.println("Sirul nostru de numere este:");
		
		for(int i=0;i<sir.length;i++)
		{
			System.out.print(sir[i]+"\t");
		}
	}

	
	public void afisare_sir_inversat()
	{
		System.out.println("");
		System.out.println("Sirul nostru inversat este:");
		
		for(int i=sir.length-1;i>=0;i--)
		{
			System.out.print(sir[i]+"\t");
		}
	}
	
	public void afisare_valoripozitve()
	{
		System.out.println("");
		System.out.println("Valorile pozitive din sir sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]>0)
			{
			System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_valorinegative()
	{
		System.out.println("");
		System.out.println("Valorile negative sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]<0)
			{
				System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_valoripare()
	{
		System.out.println("");
		System.out.println("Valorile pare sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]%2==0)
			{
				System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_valoriimpare()
	{
		System.out.println("");
		System.out.println("Valorile impare sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]%2==1)
			{
				System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_divizibilcu2()
	{
		System.out.println("");
		System.out.println("Valorile care se impart la 2 sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]%2==0)
			{
				System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_divizibilcu3()
	{
		System.out.println("");
		System.out.println("Valorile care se impart la 3 sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]%3==0)
			{
				System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_divizibilcu4()
	{
		System.out.println("");
		System.out.println("Valorile care se impart la 4 sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]%4==0)
			{
				System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_divizibilcu5()
	{
		System.out.println("");
		System.out.println("Valorile care se impart la 5 sunt:");
		
		for(int i=0;i<sir.length;i++)
		{
			if(sir[i]%5==0)
			{
				System.out.print(sir[i]+"\t");
			}
		}
	}
	
	public void afisare_valoaremaxima()
	{
		System.out.println("");
		System.out.println("Valoarea maxima din sir este:");
		
		for(int i=0;i<sir.length;i++)
		{
			
		}
	}
	
	public void afisare_valoareminima()
	{
		System.out.println("");
		System.out.println("Valoare minima din sir este:");
		
		for(int i=0;i<sir.length;i++)
		{
			
		}
	}
	
	public void afisare_sircrescator()
	{
		System.out.println("");
		System.out.println("Sirul ordonat crescator este:");
		
		for(int i=0;i<sir.length;i++)
		{
			
		}
	}
	
	public void afisare_sirdescrescator()
	{
		System.out.println("");
		System.out.println("Sirul ordonat descrescator este:");
		
		for(int i=0;i<sir.length;i++)
		{
			
		}
	}
	
	
}

public class Test1 {

	public static void main(String[] args) 
	{
      Sirul object = new Sirul();
      
      object.afisare_sir();
      object.afisare_sir_inversat();
      object.afisare_valoripozitve();
      object.afisare_valorinegative();
      object.afisare_valoripare();
      object.afisare_valoriimpare();
      object.afisare_divizibilcu2();
      object.afisare_divizibilcu3();
      object.afisare_divizibilcu4();
      object.afisare_divizibilcu5();
      

    }
	

	
}