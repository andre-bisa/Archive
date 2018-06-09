/**
 * 
 */
package fondt2.tlc.plans.tests;

import java.time.DayOfWeek;
import java.time.LocalDateTime;

import fondt2.tlc.plans.Rate;

/**
 * @author lab4_103
 *
 */
public class MockPreciseRate implements Rate{
	
	private int count = 0;
	
	private double price;
	
	public MockPreciseRate(double price) {
		this.price = price;
		count = 0;
	}
	
	@Override
	public String getName() {
		return "MockName";
	}

	@Override
	public boolean isApplicableTo(String destinationNumber) {
		return true;
	}

	@Override
	public double getCostPerInterval(LocalDateTime current) {
		count++;
		double cost = price;
		if (current.getDayOfWeek().equals(DayOfWeek.SUNDAY)) {
			cost = 0;
		}
		return cost;
	}

	@Override
	public boolean isValid() {
		return true;
	}
	
}
