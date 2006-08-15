/*
 * ScannerTest.java
 * JUnit based test
 *
 * Created on 16. August 2006, 00:55
 */

package jmathtoolkit.util;

import junit.framework.*;

/**
 *
 * @author Linna
 */
public class ScannerTest extends TestCase {
    
    public ScannerTest(String testName) {
        super(testName);
    }

    protected void setUp() throws Exception {
    }

    protected void tearDown() throws Exception {
    }

    public static Test suite() {
        TestSuite suite = new TestSuite(ScannerTest.class);
        
        return suite;
    }
    
}
