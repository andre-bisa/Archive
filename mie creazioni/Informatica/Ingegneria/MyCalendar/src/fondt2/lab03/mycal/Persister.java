/**
 * 
 */
package fondt2.lab03.mycal;

import java.io.IOException;

/**
 * @author s0000753177
 *
 */
public interface Persister <TYPE> {
	public TYPE load() throws IOException;
	
	public void save(TYPE appointments) throws IOException;
}
