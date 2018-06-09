package fondt2.tlc.plans.rates;

public class DestinationOperatorBandRate extends BandsRate {
	private String operatorName;

	public DestinationOperatorBandRate(String name, Band[] bands,
			String operatorName) {
		super(name, bands);
		this.operatorName = operatorName;
	}

	@Override
	public boolean isApplicableTo(String destinationNumber) {
		String operatorName = OperatorDecoder
				.getNameFromNumber(destinationNumber);
		return this.operatorName.equals(operatorName);
	}
}
