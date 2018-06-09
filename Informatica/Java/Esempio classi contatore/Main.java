public class Main {
	public static void main(String[] args) {
		Counter a = new Counter();
		a.reset();
		a.inc();
		a.inc();
		System.out.println(a.getValue());
	}
}