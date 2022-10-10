import org.openqa.selenium.By;
import org.openqa.selenium.chrome.ChromeDriver;

public class ThirdProjectSelenium {

	public static void main(String[] args) {
		
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\Vlad\\Downloads\\chromedriver.exe");
		
		ChromeDriver object= new ChromeDriver();
		
		object.get("https://myelectrica.ro/index.php?pagina=login");
		
		System.out.println(object.getCurrentUrl());
		
		object.findElement(By.className("pull-right")).click();
		object.findElement(By.className("accordion-toggle")).click();
		object.findElement(By.id("myelectrica_email")).sendKeys("todorut178@yahoo.com");
		object.findElement(By.id("myelectrica_recuperare_utilizator")).click();
		
		

	}

}
