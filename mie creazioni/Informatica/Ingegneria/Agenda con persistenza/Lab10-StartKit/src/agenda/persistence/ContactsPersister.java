/**
 * 
 */
package agenda.persistence;

import java.io.IOException;
import java.io.Reader;
import java.io.Writer;
import java.util.List;

import agenda.domainModel.Contact;
import agenda.exceptions.BadFileFormatException;

/**
 * @author s0000753177
 *
 */
public interface ContactsPersister {
	
	public List<Contact> load(Reader reader) throws IOException, BadFileFormatException;
	
	public void save(List<Contact> contacts, Writer writer) throws IOException;
	
}
