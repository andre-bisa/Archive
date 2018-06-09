/**
 * 
 */
package agenda.persistence;

import java.util.HashMap;
import java.util.Map;

import agenda.domainModel.Detail;

/**
 * @author s0000753177
 *
 */
public class DetailPersisterFactory {
	
	private Map<String, Persister<Detail>> mappaPersister;
	private static DetailPersisterFactory instance;

	public static DetailPersisterFactory getInstance()
	{
		if (instance == null)
		{
			instance = new DetailPersisterFactory();
		}
		return instance;
	}

	private DetailPersisterFactory() {
		this.mappaPersister = new HashMap<>();
		
		this.mappaPersister.put("Phone", new PhonePersister());
		this.mappaPersister.put("Address", new AddressPersister());
		this.mappaPersister.put("EMail", new EMailPersister());
				
	}

	public Persister<Detail> get(String name) {
		return this.mappaPersister.get(name);
	}

}
