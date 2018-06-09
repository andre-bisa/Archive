/**
 * 
 */
package agenda.persistence;

import java.util.StringTokenizer;

import agenda.domainModel.Detail;
import agenda.domainModel.Phone;
import agenda.exceptions.BadFileFormatException;

/**
 * @author s0000753177
 *
 */
public class PhonePersister implements Persister<Detail> {

	private static final String SEPARATOR = ";";
	
	@Override
	public Detail load(StringTokenizer source) throws BadFileFormatException {
		if (source.countTokens() != 2) {
			throw new BadFileFormatException("Phone deve avere esattamente 3 token!");
		}
		
		Phone read = new Phone();
		
		read.setDescription(source.nextToken());
		read.setValue(source.nextToken());
		
		return read;
	}

	@Override
	public void save(Detail toSave, StringBuilder sb) {
		
		Phone current = (Phone) toSave;
		
		sb.append(current.getName() + SEPARATOR);
		sb.append(current.getDescription() + SEPARATOR);
		sb.append(current.getValue() + "\n");
		
	}

}
