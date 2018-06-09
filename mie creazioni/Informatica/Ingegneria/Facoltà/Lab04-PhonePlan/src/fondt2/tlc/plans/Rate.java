package fondt2.tlc.plans;

import java.time.LocalDateTime;

public interface Rate {
	String getName();

	boolean isApplicableTo(String destinationNumber);

	double getCostPerInterval(LocalDateTime current);

	boolean isValid();
}
