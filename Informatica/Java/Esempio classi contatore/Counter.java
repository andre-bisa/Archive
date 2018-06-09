public class Counter {
	private int value;
	private int val_res = 0;
	private int val_inc = 1;
	
	public Counter(int reset, int inc) {
		this.val_res = reset;
		this.val_inc = inc;
	}
	
	public Counter() {
		this.val_res = 0;
		this.val_inc = 1;
	}
	
	public void inc() {
		value += val_inc;
	}
	
	public void reset() {
		value = val_res;
	}
	
	public int getValue() {
		return value;
	}
}