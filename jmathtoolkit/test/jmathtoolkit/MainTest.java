/*
 * MainTest.java
 * JUnit based test
 *
 * Created on 17 August 2006, 06:20
 */

package jmathtoolkit;

import junit.framework.*;

/**
 *
 * @author daspan
 */
public class MainTest extends TestCase {
    
    public MainTest(String testName) {
        super(testName);
    }

    protected void setUp() throws Exception {
    }

    protected void tearDown() throws Exception {
    }

    public static Test suite() {
        TestSuite suite = new TestSuite(MainTest.class);
        
        return suite;
    }

    /**
     * Test of main method, of class jmathtoolkit.Main.
     */
    public void testMain() {
        System.out.println("main");
        
        String[] args = null;
        
        Main.main(args);
        
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
