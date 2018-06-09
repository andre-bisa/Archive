/**
 * 
 */
package agenda.persistence;

import java.util.StringTokenizer;

import agenda.domainModel.Detail;
import agenda.domainModel.EMail;
import agenda.exceptions.BadFileFormatException;

/**
 * @author s0000753177
 *
 */
public class EMailPersister implements Persister<Detail> {
	
	private static final String SEPARATOR = ";";
	
	@Override
	public Detail load(StringTokenizer source) throws BadFileFormatException {

		if (source.countTokens() != 2) {
			throw new BadFileFormatException("EMail deve avere esattamente 3 token!");
		}
		
		EMail read = new EMail();
		
		read.setDescription(source.nextToken());
		read.setValue(source.nextToken());
		
		return read;
		
	}

	@Override
	public void save(Detail toSave, StringBuilder sb) {
		EMail current = (EMail) toSave;
		
		sb.append(toSave.getName() + SEPARATOR);
		sb.append(current.getDescription() + SEPARATOR);
		sb.append(current.getValue() + "\n");
		
	}

}
