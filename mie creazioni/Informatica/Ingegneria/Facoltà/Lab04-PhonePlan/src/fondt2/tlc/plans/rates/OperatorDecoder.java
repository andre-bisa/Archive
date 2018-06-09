package fondt2.tlc.plans.rates;

public class OperatorDecoder {

	public static String getNameFromNumber(String destinationNumber) {
		if (destinationNumber.startsWith("+3933")) {
			return "TIM";
		}
		if (destinationNumber.startsWith("+3934")) {
			return "Vodafone";
		}
		if (destinationNumber.startsWith("+3932")) {
			return "Wind";
		}
		if (destinationNumber.startsWith("+390")) {
			return "Italy";
		}
		return null;
	}

}
