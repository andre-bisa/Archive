/**
 * 
 */
package agenda.domainModel;

import java.util.LinkedList;
import java.util.List;

import agenda.gui.utils.ColumnTable;

/**
 * @author s0000753177
 *
 */
public class Contact implements Comparable<Contact> {

	private List<Detail> detailList;
	private String firstName;
	private String secondName;
	
	public Contact() {
		this.detailList = new LinkedList<>();
	}
	
	@ColumnTable(name = "Nome")
	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	@ColumnTable(name = "Cognome")
	public String getSecondName() {
		return secondName;
	}

	public void setSecondName(String secondName) {
		this.secondName = secondName;
	}

	@ColumnTable(name = "Dettagli")
	public List<Detail> getDetailList() {
		return detailList;
	}

	@Override
	public int compareTo(Contact toCompare) {
		return this.getSecondName().compareToIgnoreCase(toCompare.getSecondName());
	}
	
	public String toString() {
		return this.getSecondName() + " " + this.getFirstName();
	}

}
