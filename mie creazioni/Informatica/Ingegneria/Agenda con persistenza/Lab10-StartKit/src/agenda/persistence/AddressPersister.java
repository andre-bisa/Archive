/**
 * 
 */
package agenda.persistence;

import java.util.StringTokenizer;

import agenda.domainModel.Address;
import agenda.domainModel.Detail;
import agenda.exceptions.BadFileFormatException;

/**
 * @author s0000753177
 *
 */
public class AddressPersister implements Persister<Detail> {

	private static final String SEPARATOR = ";";
	
	@Override
	public Detail load(StringTokenizer source) throws BadFileFormatException {

		if (source.countTokens() != 6) {
			throw new BadFileFormatException("Address deve avere esattamente 3 token!");
		}
		
		Address read = new Address();
		
		read.setDescription(source.nextToken());
		read.setStreet(source.nextToken());
		read.setNumber(source.nextToken());
		read.setZipCode(source.nextToken());
		read.setCity(source.nextToken());
		read.setState(source.nextToken());
		
		return read;
		
	}

	@Override
	public void save(Detail toSave, StringBuilder sb) {
		
		Address current = (Address) toSave;
		
		sb.append(current.getName() + SEPARATOR);
		sb.append(current.getDescription() + SEPARATOR);
		sb.append(current.getStreet() + SEPARATOR);
		sb.append(current.getNumber() + SEPARATOR);
		sb.append(current.getZipCode() + SEPARATOR);
		sb.append(current.getCity() + SEPARATOR);
		sb.append(current.getState() + "\n");

	}

}
