/**
 * 
 */
package fondt2.tlc.plans;

/**
 * @author lab4_103
 *
 */
public interface PhonePlan {
	public double getCallCost(PhoneCall call);
	public String getName();
	public boolean isValid();
}
