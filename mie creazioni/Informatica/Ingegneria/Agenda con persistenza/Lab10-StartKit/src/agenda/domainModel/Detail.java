/**
 * 
 */
package agenda.domainModel;

import agenda.gui.utils.ColumnTable;

/**
 * @author s0000753177
 *
 */
public abstract class Detail {

	private String description;
	
	@ColumnTable(name = "Tipo")
	public abstract String getName();
	
	@ColumnTable(name = "")
	public abstract String getValues();
	
	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}
	
	public String toString() {
		return this.getName() + " " + this.getDescription() + " " + this.getValues();
	}

}
