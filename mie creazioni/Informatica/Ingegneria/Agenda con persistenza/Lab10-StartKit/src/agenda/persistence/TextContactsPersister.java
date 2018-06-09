/**
 * 
 */
package agenda.persistence;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.Reader;
import java.io.Writer;
import java.util.LinkedList;
import java.util.List;
import java.util.StringTokenizer;

import agenda.domainModel.Contact;
import agenda.domainModel.Detail;
import agenda.exceptions.BadFileFormatException;

/**
 * @author s0000753177
 *
 */
public class TextContactsPersister implements ContactsPersister{

	private static final String STARTCONTACT = "StartContact";
	private static final String ENDCONTACT = "EndContact";

	private void writeDetails(List<Detail> details, StringBuilder stringBuilder) {
		for (Detail detail : details) {
			DetailPersisterFactory.getInstance().get(detail.getName()).save(detail, stringBuilder);;	
		}
	}

	public void save(List<Contact> contacts, Writer writer) throws IOException {
		for (Contact contact : contacts) {
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.append(STARTCONTACT + "\n");
			stringBuilder.append(contact.getSecondName() + ";" + contact.getFirstName() + "\n");
			writeDetails(contact.getDetailList(), stringBuilder);
			stringBuilder.append(ENDCONTACT +"\n");
			writer.write(stringBuilder.toString());
		}
	}

	private void readContactValues(Contact contact, String readLine) throws BadFileFormatException {
		StringTokenizer tokenizzatore = new StringTokenizer(readLine, ";");
		if (tokenizzatore.countTokens() != 2) {
			throw new BadFileFormatException("Errore formato file. I campi devono essere 2");
		}
		contact.setSecondName(tokenizzatore.nextToken());
		contact.setFirstName(tokenizzatore.nextToken());
	}

	private void readDetails(BufferedReader buffReader, List<Detail> details) throws IOException, BadFileFormatException {
		String readLine = "";
		boolean stop = false;

		while ((!stop) && ((readLine = buffReader.readLine()) != null)) {
			if (readLine.equals(ENDCONTACT)) {
				stop = true;
			} else {
				StringTokenizer tokenizzatore = new StringTokenizer(readLine, ";");
				Detail toAdd = DetailPersisterFactory.getInstance().get(tokenizzatore.nextToken()).load(tokenizzatore);
				details.add(toAdd);
			}
		}

		if (!stop) {
			throw new BadFileFormatException("Formattazione file non valida.");
		}
	}

	public List<Contact> load(Reader reader) throws IOException, BadFileFormatException {
		List<Contact> result = new LinkedList<>();

		BufferedReader buffReader = new BufferedReader(reader);

		String readLine = "";
		while ((readLine = buffReader.readLine()) != null) {
			readLine = readLine.trim();
			if (!readLine.equals("")) {
				if (! readLine.equals(STARTCONTACT)) {
					throw new BadFileFormatException("Errore formato file.");
				}

				readLine = buffReader.readLine(); // leggo nuova riga

				Contact currentContact = new Contact();

				readContactValues(currentContact, readLine);

				readDetails(buffReader, currentContact.getDetailList());

				result.add(currentContact);
			}
		}

		return result;
	}

}
