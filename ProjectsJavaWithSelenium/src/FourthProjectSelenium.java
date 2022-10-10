import org.openqa.selenium.By;
import org.openqa.selenium.chrome.ChromeDriver;

public class FourthProjectSelenium {

	public static void main(String[] args) {
		
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\Vlad\\Downloads\\chromedriver.exe");
		
		ChromeDriver driver= new ChromeDriver();
		
		driver.get("https://www.infofer.ro/index.php/ro/");
		
		System.out.println(driver.getCurrentUrl());
		
		driver.findElement(By.id("input-date-departure")).sendKeys("02.10.2022");
		driver.findElement(By.id("input-station-departure-name")).sendKeys("Huedin");
		driver.findElement(By.id("input-station-arrival-name")).sendKeys("Cluj Napoca");
		
		

	}

}
