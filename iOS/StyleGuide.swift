
// Enums should use upper-case first letter camel casing for the type name
enum AEnum {
    // Each case should have it's own line and should be camel cased
    case aEnum
    case bEnum
}

// Where enums have a raw value you should explicitly declare those values where practical to do so
enum AnotherEnum: Int {
    case aRedEnum = 1
    case aBlueEnum = 2
}

protocol StyleGuideProtocol {
    func doSomeWork()
}

/*
 * Whilst swift supports multple class declarations in a file we generally don't use this.
 * In iOS a file is very tightly couple to the member which it is declaring.
 * It is unusual to see multiple internal classes in a single file
 *
 * An exception to this rule is to have a protocol declaration for the class at the top of the file where the protocol declaration is tightly coupled to the classes purpose.
 *
 */
class StyleGuide {
    
    /*
     * Use fileprivate for fields rather than private as works better when using extensions
     *
     * All fields should use camel casing and placed at top of the class
     *
     */
    fileprivate let privateField: Bool
    
    /*
     * Use constants for public field getters where possible
     */
    let publicField: Bool
    
    /*
     * You may use computed properties but their operations should be keep simple a function implies work
     * but a var is considered simple non-IO calculations
     *
     * Where a getter does not require a setter you should omit the get { } clause
     */
    var computedProperty: Int {
         return 0
    }
}

// Protocol conformance should prefer adding a separate class extension for method implementations
extension StyleGuide: StyleGuideProtocol {
    // Empty functions should have it's opening and closing brace
    func doSomeWork() {}
}

private extension StyleGuide {
    // A private function should be declared within a private extension
    func aPrivateFunc() {
        let enumValue = AEnum.aEnum
        /*
         * Switch statements should be exhaustive where practical do so
         * this is especially true where then enum is one of our own creation.
         */
        switch enumValue {
        case .aEnum:
            break
        case .bEnum:
            break
        }
    }
}

class StyleGuideView: UIView {
    /*
     * Be especially explicit when using IBOutlets or view variables
     *
     * They should include the type in their name along with the intented user purpose
     *
     * It is generally frowned upon to use implicitally unwrapped variables however they are considered
     * the norm for view variables
     */
    var viewGuideButton: UIButton!
    var searchGuideTextField: UITextField!
}
