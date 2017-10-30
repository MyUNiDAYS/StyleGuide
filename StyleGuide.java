package StyleGuide;

import android.content.Context;
import android.support.annotation.Nullable;
import java.util.Random;

/**
 * Classes should be public by default unless package is possible.
 * If comments span multiple lines you should use '*' syntax for comments
 *
 * Spaces should be used over tabs. The standard number of spaces per indentation is 4.
 *
 * static should always precede instance
 * public should always precede package
 * package should always precede private
 *
 */
public class StyleGuide {

    /*
    * Constants which are required to be static should be declared at the top of the class using uppercase snakecasing
    * generally these should always be final.
    */
    public static final int JOB_ID = 1;

    private static final String LOGGER_NAME = "StyleGuide";
    // Fields should always be declared as privates and accessed using getters or setters
    // Final should also be used to show mutability
    private final Context context;

    /*
    * Fields which are an interface should not include the I in their name
     */
    private IJobScheduler jobScheduler;

    /*
    * Fields which are nullable should be annotated as @Nullable
    * Each annotation on a member should have it's own line.
    *
    * In broader terms the support annotations should be used as they strengthen Android Studio's
    * ability to check nullibility, resource references and usage. The exception to this is the use
    * of non-null. Given java's affinity for null-pointer exceptions the use non-null should be
    * limited as it may encourage sloppy null checking.
    *
     */
    @Nullable
    private String name;

    /*
    * Constructor parameters should use the same names as the constructed objects internal fields
    * 'this' must then be used to specify which variable you are referencing.
    * The first brace should be on the same line as the method declaration with the final brace on its
    * own line
     */
    public StyleGuide(Context context) {
        this.context = context;
    }

    /* Where methods spread over multiple lines a single white space should be left at the top of the method to improve readability.
    * Methods should follow the naming convention of verbs at the start with nounds at the end.
     */
    public void scheduleJobIfNeeded() {

        if(!isJobAlreadyScheduled()) {
            scheduleJob();
        }
    }

    // Where a method only consists of one line you do not need to leave a single white line as per the instructions for a multiline method.
    public void cancelScheduledJob() {
        jobScheduler.cancel(JOB_ID);
    }

    /*
    * Getters of a field should start with get
    * They should not perform calculations or IO operations.
     */
    public Context getContext() {
        // Use explicit this for member field access.
        return this.context;
    }

    private boolean isJobAlreadyScheduled() {
        final int i = new Random().nextInt();
        /*
        * Braces are always used in an if statement.
        * Where an else clause is used both the closing brace of the if clause and the start brace are on the same line.
        * Use variables to simplify complex if statements.
         */
        if (i == 0) {
            return true;
        } else {
            return false;
        }
    }

    private void scheduleJob() {}

    /*
    *
    * Private classes which are only needed for the parent classes purposes should be placed at the
    * bottom of the fille
    *
    * Where an interface is deemed to only need one implementation in the app's lifetime or the interface
    * only exists for testing. The implementation should have the same name but remove the 'I' prefix
     */
    private class JobScheduler implements IJobScheduler {

        /*
        * Methods are marked with @Override annotation whenever it is legal.
        *
        * Methods with empty implementations should have their braces closed on the same line.
         */
        @Override
        public void cancel(int jobId) {}
    }

    /*
    * Interfaces should be prefixed with an 'I'.
     */
    interface IJobScheduler {
        void cancel(int jobId);
    }
}