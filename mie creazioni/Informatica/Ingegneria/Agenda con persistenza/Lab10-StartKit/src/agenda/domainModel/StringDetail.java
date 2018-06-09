/**
 * 
 */
package agenda.domainModel;

import agenda.gui.utils.ColumnTable;

/**
 * @author s0000753177
 *
 */
public abstract class StringDetail extends Detail {

	private String value;
	
	@ColumnTable(name = "Valore")
	public String getValue() {
		return value;
	}

	public void setValue(String value) {
		this.value = value;
	}

	public abstract String getName();

	@Override
	public String getValues() {
		return this.getValue();
	}

}
