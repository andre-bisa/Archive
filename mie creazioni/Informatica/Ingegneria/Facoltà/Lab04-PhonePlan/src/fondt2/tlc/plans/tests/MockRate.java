package fondt2.tlc.plans.tests;

import java.time.LocalDateTime;

import fondt2.tlc.plans.*;

public class MockRate implements Rate {

	public String getName() {
		return "MockRate";

	}

	public boolean isApplicableTo(String destinationNumber) {
		return true;

	}

	public double getCostPerInterval(LocalDateTime current) {
		return 1;

	}

	public boolean isValid() {
		return true;
	}

}
