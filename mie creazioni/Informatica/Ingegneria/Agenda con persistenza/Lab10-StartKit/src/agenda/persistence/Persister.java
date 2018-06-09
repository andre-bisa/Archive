/**
 * 
 */
package agenda.persistence;

import java.util.StringTokenizer;

import agenda.exceptions.BadFileFormatException;

/**
 * @author s0000753177
 *
 */
public interface Persister<T> {
	
	public T load(StringTokenizer source) throws BadFileFormatException;
	
	public void save(T toSave, StringBuilder sb);
	
}
