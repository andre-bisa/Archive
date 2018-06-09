/**
 * 
 */
package agenda.domainModel;

import agenda.gui.utils.ColumnTable;

/**
 * @author s0000753177
 *
 */
public class Address extends Detail {
	
	private String city;
	private String number;
	private String state;
	private String street;
	private String zipCode;
	
	@ColumnTable(name = "Città")
	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	@ColumnTable(name = "Civico")
	public String getNumber() {
		return number;
	}

	public void setNumber(String number) {
		this.number = number;
	}

	@ColumnTable(name = "Stato")
	public String getState() {
		return state;
	}

	public void setState(String state) {
		this.state = state;
	}

	@ColumnTable(name = "Via")
	public String getStreet() {
		return street;
	}

	public void setStreet(String street) {
		this.street = street;
	}

	@ColumnTable(name = "CAP")
	public String getZipCode() {
		return zipCode;
	}

	public void setZipCode(String zipCode) {
		this.zipCode = zipCode;
	}

	@Override
	public String getName() {
		return "Address";
	}

	@Override
	public String getValues() {
		return this.getStreet() + ", " + this.getNumber() + ", " + this.getZipCode() + ", " + this.getCity() + ", " + this.getState();
	}

}
