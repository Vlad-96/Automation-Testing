import org.openqa.selenium.By;
import org.openqa.selenium.chrome.ChromeDriver;

public class FirstProjectSelenium {

	public static void main(String[] args) {
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\Vlad\\Downloads\\chromedriver.exe");
		
		ChromeDriver object= new ChromeDriver();
		
		object.get("https://myelectrica.ro/index.php?pagina=inregistrare-cont-nou");
		
		System.out.println(object.getCurrentUrl());
		
		object.findElement(By.id("myelectrica_finregistrare_nume_prenume")).sendKeys("Todorut Vlad");
		object.findElement(By.id("myelectrica_finregistrare_email")).sendKeys("todorut178@yahoo.com");
		object.findElement(By.id("myelectrica_finregistrare_repetare_email")).sendKeys("todorut178@yahoo.com");
		object.findElement(By.xpath("//*[@id=\"myelectrica_finregistrare_parola\"]")).sendKeys("676767676");
		object.findElement(By.xpath("//*[@id=\"myelectrica_finregistrare_repetare_parola\"]")).sendKeys("676767676");
		//object.close();
		

	}

}
