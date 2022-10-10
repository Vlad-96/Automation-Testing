import org.openqa.selenium.By;
import org.openqa.selenium.chrome.ChromeDriver;

public class SecondProjectSelenium {

	public static void main(String[] args) {
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\Vlad\\Downloads\\chromedriver.exe");
		
		ChromeDriver object= new ChromeDriver();
		
		object.get("https://myelectrica.ro/index.php?pagina=login");
		
		System.out.println(object.getCurrentUrl());
		
		object.findElement(By.id("myelectrica_utilizator")).sendKeys("todorut178@yahoo.com");
		object.findElement(By.xpath("//*[@id=\"myelectrica_pass\"]")).sendKeys("Carte2022");
		object.findElement(By.id("myelectrica_login_btn")).click();

	}

}
