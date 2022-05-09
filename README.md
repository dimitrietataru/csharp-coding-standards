# C# Coding Standards

An opinionated C# .editorconfig  
Compatible with Visual Studio 2022, and 2019*.


## Table of contents
* [Visual Studio options](#visual-studio-options)
  * Advanced
    * [Using directives](#advanced--using-directives)
  * Code style
    * General
      * [this. preferences](#code-style--general--this-preferences)
      * [Predefined type preferences](#code-style--general--predefined-type-preferences)
      * [var preferences](#code-style--general--var-preferences)
      * [Code block preferences](#code-style--general--code-block-preferences)
      * [Parentheses preferences](#code-style--general--parentheses-preferences)
      * [Expression preferences](#code-style--general--expression-preferences)
      * [Expression-bodied members](#code-style--general--expression-bodied-members)
      * [Pattern matching preferences](#code-style--general--pattern-matching-preferences)
      * [Variable preferences](#code-style--general--variable-preferences)
      * [null checking](#code-style--general--null-checking)
      * [using preferences](#code-style--general--using-preferences)
      * [Modifier preferences](#code-style--general--modifier-preferences)
      * [Parameter preferences](#code-style--general--parameter-preferences)
      * [New line preferences](#code-style--general--new-line-preferences)
    * Formatting
      * [General](#code-style--formatting--general)
      * Indentation
        * [General](code-style--formatting--indentation--general)
        * [Label indentation](#code-style--formatting--indentation--label-indentation)
      * New lines
        * [New line options for braces](#code-style--formatting--new-lines--new-line-options-for-braces)
        * [New line options for keywords](#code-style--formatting--new-lines--new-line-options-for-keywords)
        * [New line options for expressions](#code-style--formatting--new-lines--new-line-options-for-expressions)
      * Spacing
        * [Set spacing for method declarations](#code-style--formatting--spacing--set-spacing-for-method-declarations)
        * [Set spacing for method calls](#code-style--formatting--spacing--set-spacing-for-method-calls)
        * [Set other spacing options](#code-style--formatting--spacing--set-other-spacing-options)
        * [Set spacing for brackets](#code-style--formatting--spacing--set-spacing-for-brackets)
        * [Set spacing for delimiters](#code-style--formatting--spacing--set-spacing-for-delimiters)
        * [Set spacing for operators](#code-style--formatting--spacing--set-spacing-for-operators)
      * [Wrapping](#code-style--formatting--wrapping)
* [Microsoft.CodeAnalysis.NetAnalyzers](#microsoftcodeanalysisnetanalyzers)
  * [Design](#microsoftcodeanalysisnetanalyzers--design)
  * [Documentation](#microsoftcodeanalysisnetanalyzers--documentation)
  * [Globalization](#microsoftcodeanalysisnetanalyzers--globalization)
  * [Interoperability](#microsoftcodeanalysisnetanalyzers--interoperability)
  * [Maintainability](#microsoftcodeanalysisnetanalyzers--maintainability)
  * [Naming](#microsoftcodeanalysisnetanalyzers--naming)
  * [Performance](#microsoftcodeanalysisnetanalyzers--performance)
  * [Reliability](#microsoftcodeanalysisnetanalyzers--reliability)
  * [Security](#microsoftcodeanalysisnetanalyzers--security)
  * [Usage](#microsoftcodeanalysisnetanalyzers--usage)


## Visual Studio options

### Advanced | Using directives
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Place _System_ directives first when sorting usings                                   |   ☐   |
| Separate using directive groups                                                       |   ☐   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_sort_system_directives_first = false
dotnet_separate_import_directive_groups = false
```

</details>


### Code Style | General | _this._ preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Qualify field access with _this._                                     | Do not prefer _this_      | ⚠ Warning    |
| Qualify property access with _this._                                  | Do not prefer _this_      | ⚠ Warning    |
| Qualify method access with _this._                                    | Do not prefer _this_      | ⚠ Warning    |
| Qualify event access with _this._                                     | Do not prefer _this_      | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_qualification_for_event = false:warning
dotnet_style_qualification_for_field = false:warning
dotnet_style_qualification_for_method = false:warning
dotnet_style_qualification_for_property = false:warning
```

</details>


### Code Style | General | Predefined type preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| For locals, parameters, and members                                   | Prefer predefined type    | ⚠ Warning    |
| For member access expressions                                         | Prefer predefined type    | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_predefined_type_for_locals_parameters_members = true:warning
dotnet_style_predefined_type_for_member_access = true:warning
```

</details>


### Code Style | General | _var_ preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| For built-in types                                                    | Prefer explicit type      | 🛈 Suggestion  |
| When variable type is apparent                                        | Prefer _var_              | 🛈 Suggestion  |
| Elsewhere                                                             | Prefer _var_              | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_var_elsewhere = true:suggestion
csharp_style_var_for_built_in_types = false:suggestion
csharp_style_var_when_type_is_apparent = true:suggestion
```

</details>


### Code Style | General | Code block preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer braces                                                         | Yes                       | ⚠ Warning    |
| Namespace declarations                                                | File scoped               | 🛈 Suggestion  |
| Prefer auto properties                                                | Yes                       | 🞅 Refactoring |
| Prefer simple _using_ statement                                       | Yes                       | 🛈 Suggestion  |
| Prefer _System.HashCode_ in 'GetHashCode'                             | Yes                       | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_prefer_braces = true:warning
csharp_style_namespace_declarations = file_scoped:suggestion
csharp_prefer_simple_using_statement = true:suggestion
dotnet_style_prefer_auto_properties = true:silent
# Missing: Prefer _System.HashCode_ in 'GetHashCode'
```

</details>


### Code Style | General | Parentheses preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| In arithmetic operators: _*_ _/_ _%_ _+_ _-_ _<<_ _>>_ _&_ _^_        | Always for clarity        | 🛈 Suggestion  |
| In other binary operators: _&&_ _??_ _and_ _or_                       | Always for clarity        | 🛈 Suggestion  |
| In relational operators: _<_ _>_ _<=_ _>=_ _is_ _as_ _==_ _!=_        | Always for clarity        | 🛈 Suggestion  |
| In other operators                                                    | Never if unnecessary      | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_parentheses_in_arithmetic_binary_operators = always_for_clarity:suggestion
dotnet_style_parentheses_in_relational_binary_operators = always_for_clarity:suggestion
dotnet_style_parentheses_in_other_binary_operators = always_for_clarity:suggestion
dotnet_style_parentheses_in_other_operators = never_if_unnecessary:warning
```

</details>


### Code Style | General | Expression preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer object initializer                                             | Yes                       | 🛈 Suggestion  |
| Prefer collection initializer                                         | Yes                       | 🛈 Suggestion  |
| Prefer simplified boolean expressions                                 | Yes                       | ⚠ Warning    |
| Prefer switch expression                                              | Yes                       | 🛈 Suggestion  |
| Prefer conditional expression over _if_ with assignments              | Yes                       | 🞅 Refactoring |
| Prefer conditional expression over _if_ with returns                  | No                        | 🞅 Refactoring |
| Prefer explicit tuple name                                            | Yes                       | 🛈 Suggestion  |
| Prefer simple 'default' expression                                    | Yes                       | ⚠ Warning    |
| Prefer inferred tuple element names                                   | No                        | 🛈 Suggestion  |
| Prefer inferred anonymous type member names                           | Yes                       | 🞅 Refactoring |
| Prefer local function over anonymous function                         | Yes                       | ⚠ Warning    |
| Prefer compound assignments                                           | Yes                       | ⚠ Warning    |
| Prefer implicit object creation when type is aparent                  | Yes                       | 🛈 Suggestion  |
| Prefer index operator                                                 | Yes                       | 🛈 Suggestion  |
| Prefer range operator                                                 | Yes                       | 🛈 Suggestion  |
| Prefer tuple swap                                                     | Yes                       | 🛈 Suggestion  |
| Avoid unused value assignments                                        | Discard                   | 🛈 Suggestion  |
| Avoid expression statements that implicitly ignore value              | Discard                   | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_object_initializer = true:suggestion
dotnet_style_collection_initializer = true:suggestion
dotnet_style_prefer_simplified_boolean_expressions = true:warning
csharp_style_prefer_switch_expression = true:suggestion
dotnet_style_prefer_conditional_expression_over_assignment = true:silent
dotnet_style_prefer_conditional_expression_over_return = false:silent
dotnet_style_explicit_tuple_names = true:suggestion
csharp_prefer_simple_default_expression = true:warning
dotnet_style_prefer_inferred_tuple_names = false:suggestion
dotnet_style_prefer_inferred_anonymous_type_member_names = false:suggestion
csharp_style_pattern_local_over_anonymous_function = true:warning
dotnet_style_prefer_compound_assignment = true:warning
csharp_style_implicit_object_creation_when_type_is_apparent = true:suggestion
csharp_style_prefer_index_operator = true:suggestion
csharp_style_prefer_range_operator = true:suggestion
csharp_style_prefer_tuple_swap = true:suggestion
csharp_style_unused_value_assignment_preference = discard_variable:suggestion
csharp_style_unused_value_expression_statement_preference = discard_variable:suggestion
```

</details>


### Code Style | General | Expression-bodied members
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Use expression body for methods                                       | Never                     | 🞅 Refactoring |
| Use expression body for constructors                                  | Never                     | 🞅 Refactoring |
| Use expression body for operators                                     | Never                     | 🞅 Refactoring |
| Use expression body for properties                                    | When possible             | 🛈 Suggestion  |
| Use expression body for indexers                                      | When possible             | 🛈 Suggestion  |
| Use expression body for accessors                                     | When possible             | 🛈 Suggestion  |
| Use expression body for lambdas                                       | When possible             | 🛈 Suggestion  |
| Use expression body for local functions                               | Never                     | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_expression_bodied_methods = false:silent
csharp_style_expression_bodied_constructors = false:silent
csharp_style_expression_bodied_operators = false:silent
csharp_style_expression_bodied_properties = true:suggestion
csharp_style_expression_bodied_indexers = true:suggestion
csharp_style_expression_bodied_accessors = true:suggestion
csharp_style_expression_bodied_lambdas = true:suggestion
csharp_style_expression_bodied_local_functions = false:suggestion
```

</details>


### Code Style | General | Pattern matching preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer pattern matching                                               | Yes                       | 🛈 Suggestion  |
| Prefer pattern matching over _is_ with _cast_ check                   | Yes                       | ⚠ Warning    |
| Prefer pattern matching over _as_ with _null_ check                   | Yes                       | ⚠ Warning    |
| Prefer pattern matching over mixed type check                         | Yes                       | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_prefer_pattern_matching = true:suggestion
csharp_style_pattern_matching_over_is_with_cast_check = true:warning
csharp_style_pattern_matching_over_as_with_null_check = true:warning
csharp_style_prefer_not_pattern = true:suggestion
```

</details>


### Code Style | General | Variable preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer inlined variable declaration                                   | Yes                       | ⚠ Warning    |
| Prefer deconstructed variable declaration                             | Yes                       | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_inlined_variable_declaration = true:warning
csharp_style_deconstructed_variable_declaration = true:suggestion
```

</details>


### Code Style | General | _null_ checking
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer throw-expression                                               | Yes                       | 🛈 Suggestion  |
| Prefer conditional delegate call                                      | Yes                       | 🛈 Suggestion  |
| Prefer coalesce expression                                            | Yes                       | ⚠ Warning    |
| Prefer null propagation                                               | Yes                       | ⚠ Warning    |
| Prefer _is null_ for reference equality checks                        | Yes                       | ⚠ Warning    |
| Prefer _null_ check over type check                                   | Yes                       | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_throw_expression = true:suggestion
csharp_style_conditional_delegate_call = true:suggestion
dotnet_style_coalesce_expression = true:warning
dotnet_style_null_propagation = true:warning
dotnet_style_prefer_is_null_check_over_reference_equality_method = true:warning
csharp_style_prefer_null_check_over_type_check = true:suggestion
```

</details>


### Code Style | General | _using_ preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Preferred _using_ directive placement                                 | Outside namespace         | ⛔ Error      |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_using_directive_placement = outside_namespace:error
```

</details>


### Code Style | General | Modifier preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer readonly fields                                                | Yes                       | ⚠ Warning    |
| Prefer static local functions                                         | Yes                       | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_readonly_field = true:warning
csharp_prefer_static_local_function = true:warning
```

</details>


### Code Style | General | Parameter preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Avoid unused parameters                                               | Non-public methods        | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_code_quality_unused_parameters = non_public:warning
```

</details>


### Code Style | General | New line preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Allow multiple blank lines                                            | No                        | ⚠ Warning    |
| Allow embeded statements on same line                                 | No                        | ⚠ Warning    |
| Allow blank lines between consecutive braces                          | No                        | ⚠ Warning    |
| Allow statement immediately after block                               | No                        | ⚠ Warning    |
| Allow blank line after colon in constructor initializer               | No                        | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_allow_multiple_blank_lines_experimental = false:warning
csharp_style_allow_embedded_statements_on_same_line_experimental = false:warning
csharp_style_allow_blank_lines_between_consecutive_braces_experimental = false:warning
dotnet_style_allow_statement_immediately_after_block_experimental = false:warning
csharp_style_allow_blank_line_after_colon_in_constructor_initializer_experimental = false:warning
```

</details>


### Code Style | Formatting | General
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Automatically format when typing                                                      |   🗹   |
| Automatically format statement on _;_                                                 |   🗹   |
| Automatically format block on _}_                                                     |   🗹   |
| Automatically format on return                                                        |   🗹   |
| Automatically format on paste                                                         |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
# Configurable at VS level
```

</details>


### Code Style | Formatting | Indentation | General
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Indent code blocks                                                                    |   🗹   |
| Indent open and close braces                                                          |   ☐   |
| Indent case contents                                                                  |   🗹   |
| Indent case contents (when block)                                                     |   ☐   |
| Indent case labels                                                                    |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_indent_block_contents = true
csharp_indent_braces = false
csharp_indent_case_contents = true
csharp_indent_case_contents_when_block = false
csharp_indent_switch_labels = true
```

</details>


### Code Style | Formatting | Indentation | Label Indentation
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Place _goto_ labels in leftmost column                                                |   ☐   |
| Indent labels normally                                                                |   ☐   |
| Place _goto_ labels one indent less than content                                      |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_indent_labels = one_less_than_current
```

</details>


### Code Style | Formatting | New Lines | New line options for braces
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Place open brace on new line for types                                                |   🗹   |
| Place open brace on new line for methods and local functions                          |   🗹   |
| Place open brace on new line for properties, indexers, and events                     |   🗹   |
| Place open brace on new line for property, indexer, and event accessors               |   🗹   |
| Place open brace on new line for anonymous methods                                    |   🗹   |
| Place open brace on new line for control blocks                                       |   🗹   |
| Place open brace on new line for anonymous types                                      |   🗹   |
| Place open brace on new line for object, collection, array, and with initializers     |   🗹   |
| Place open brace on new line for lambda expression                                    |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_new_line_before_open_brace = all
```

</details>


### Code Style | Formatting | New Lines | New line options for keywords
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Place _else_ on new line                                                              |   🗹   |
| Place _catch_ on new line                                                             |   🗹   |
| Place _finally_ on new line                                                           |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_new_line_before_else = true
csharp_new_line_before_catch = true
csharp_new_line_before_finally = true
```

</details>


### Code Style | Formatting | New Lines | New line options for expressions
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Place members in object initializers on new line                                      |   🗹   |
| Place members in anonymous types on new line                                          |   🗹   |
| Place query expression clauses on new line                                            |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_new_line_before_members_in_object_initializers = true
csharp_new_line_before_members_in_anonymous_types = true
csharp_new_line_between_query_expression_clauses = true
```

</details>


### Code Style | Formatting | Spacing | Set spacing for method declarations
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Insert space between method name and its opening parenthesis                          |   ☐   |
| Insert space within parameter list parentheses                                        |   ☐   |
| Insert space within empty parameter list parentheses                                  |   ☐   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_space_between_method_declaration_name_and_open_parenthesis = false
csharp_space_between_method_declaration_parameter_list_parentheses = false
csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
```

</details>


### Code Style | Formatting | Spacing | Set spacing for method calls
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Insert space between method name and its opening parenthesis                          |   ☐   |
| Insert space within argument list parentheses                                         |   ☐   |
| Insert space within empty argument list parentheses                                   |   ☐   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_space_between_method_call_name_and_opening_parenthesis = false
csharp_space_between_method_call_parameter_list_parentheses = false
csharp_space_between_method_call_empty_parameter_list_parentheses = false
```

</details>


### Code Style | Formatting | Spacing | Set other spacing options
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Insert space after keywords in control flow statements                                |   🗹   |
| Insert space within parentheses of expressions                                        |   ☐   |
| Insert space within parentheses of type casts                                         |   ☐   |
| Insert space within parentheses of control flow statements                            |   ☐   |
| Insert space after cast                                                               |   ☐   |
| Insert space in declaration statements                                                |   ☐   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_space_after_keywords_in_control_flow_statements = true
csharp_space_between_parentheses = false
csharp_space_after_cast = false
csharp_space_around_declaration_statements = false
```

</details>


### Code Style | Formatting | Spacing | Set spacing for brackets
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Insert space before open square bracket                                               |   ☐   |
| Insert space within empty square brackets                                             |   ☐   |
| Insert space within square brackets                                                   |   ☐   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_space_before_open_square_brackets = false
csharp_space_between_square_brackets = false
csharp_space_between_empty_square_brackets = false
```

</details>


### Code Style | Formatting | Spacing | Set spacing for delimiters
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Insert space before colon for base or interface in type declarations                  |   🗹   |
| Insert space after colon for base or interface in type declarations                   |   🗹   |
| Insert space before comma                                                             |   ☐   |
| Insert space after comma                                                              |   🗹   |
| Insert space before dot                                                               |   ☐   |
| Insert space after dot                                                                |   ☐   |
| Insert space before semicolon in _for_ statement                                      |   ☐   |
| Insert space after semicolon in _for_ statement                                       |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_space_before_colon_in_inheritance_clause = true
csharp_space_after_colon_in_inheritance_clause = true
csharp_space_before_comma = false
csharp_space_after_comma = true
csharp_space_before_dot = false
csharp_space_after_dot = false
csharp_space_before_semicolon_in_for_statement = false
csharp_space_after_semicolon_in_for_statement = true
```

</details>


### Code Style | Formatting | Spacing | Set spacing for operators
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Ignore spaces around binary operators                                                 |   ☐   |
| Remove spaces before and after binary operators                                       |   ☐   |
| Insert space before and after binary operators                                        |   🗹   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_space_around_binary_operators = before_and_after
```

</details>


### Code Style | Formatting | Wrapping
| Description _________________________________________________________________________ | Value |
| :------------------------------------------------------------------------------------ | :---: |
| Leave block on single line                                                            |   🗹   |
| Leave statements and member declarations on the same line                             |   ☐   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_preserve_single_line_blocks = true
csharp_preserve_single_line_statements = false
```

</details>


## Microsoft.CodeAnalysis.NetAnalyzers

### Microsoft.CodeAnalysis.NetAnalyzers | Design
| Code                                                                                              | Description                                                                                                                                  | Severity      |
| :-----------------------------------------------------------------------------------------------: | :------------------------------------------------------------------------------------------------------------------------------------------- | :-----------: |
| [CA1000](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1000) | Do not declare static members on generic types                                                                                               |               |
| [CA1001](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1001) | Types that own disposable fields should be disposable                                                                                        |               |
| [CA1002](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1002) | Do not expose generic lists                                                                                                                  |               |
| [CA1003](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1003) | Use generic event handler instances                                                                                                          |               |
| [CA1005](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1005) | Avoid excessive parameters on generic types                                                                                                  |               |
| [CA1008](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1008) | Enums should have zero value                                                                                                                 |               |
| [CA1010](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1010) | Collections should implement generic interface                                                                                               |               |
| [CA1012](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1012) | Abstract types should not have public constructors                                                                                           |               |
| [CA1014](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1014) | Mark assemblies with CLSCompliantAttribute                                                                                                   |               |
| [CA1016](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1016) | Mark assemblies with AssemblyVersionAttribute                                                                                                |               |
| [CA1017](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1017) | Mark assemblies with ComVisibleAttribute                                                                                                     |               |
| [CA1018](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1018) | Mark attributes with AttributeUsageAttribute                                                                                                 |               |
| [CA1019](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1019) | Define accessors for attribute arguments                                                                                                     |               |
| [CA1021](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1021) | Avoid out parameters                                                                                                                         |               |
| [CA1024](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1024) | Use properties where appropriate                                                                                                             |               |
| [CA1027](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1027) | Mark enums with FlagsAttribute                                                                                                               |               |
| [CA1028](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1028) | Enum storage should be Int32                                                                                                                 |               |
| [CA1030](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1030) | Use events where appropriate                                                                                                                 |               |
| [CA1031](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1031) | Do not catch general exception types                                                                                                         |               |
| [CA1032](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1032) | Implement standard exception constructors                                                                                                    |               |
| [CA1033](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1033) | Interface methods should be callable by child types                                                                                          |               |
| [CA1034](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1034) | Nested types should not be visible                                                                                                           |               |
| [CA1036](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1036) | Override methods on comparable types                                                                                                         |               |
| [CA1040](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1040) | Avoid empty interfaces                                                                                                                       |               |
| [CA1041](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1041) | Provide ObsoleteAttribute message                                                                                                            |               |
| [CA1043](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1043) | Use integral or string argument for indexers                                                                                                 |               |
| [CA1044](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1044) | Properties should not be write only                                                                                                          |               |
| [CA1045](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1045) | Do not pass types by reference                                                                                                               |               |
| [CA1046](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1046) | Do not overload operator equals on reference types                                                                                           |               |
| [CA1047](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1047) | Do not declare protected members in sealed types                                                                                             |               |
| [CA1050](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1050) | Declare types in namespaces                                                                                                                  |               |
| [CA1051](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1051) | Do not declare visible instance fields                                                                                                       |               |
| [CA1052](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1052) | Static holder types should be Static or NotInheritable                                                                                       |               |
| [CA1053](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1053) | Static holder types should not have default constructors                                                                                     |               |
| [CA1054](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1054) | URI parameters should not be strings                                                                                                         |               |
| [CA1055](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1055) | URI return values should not be strings                                                                                                      |               |
| [CA1056](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1056) | URI properties should not be strings                                                                                                         |               |
| [CA1058](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1058) | Types should not extend certain base types                                                                                                   |               |
| [CA1060](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1060) | Move P/Invokes to NativeMethods class                                                                                                        |               |
| [CA1061](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1061) | Do not hide base class methods                                                                                                               |               |
| [CA1062](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1062) | Validate arguments of public methods                                                                                                         |               |
| [CA1063](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1063) | Implement IDisposable correctly                                                                                                              |               |
| [CA1064](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1064) | Exceptions should be public                                                                                                                  |               |
| [CA1065](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1065) | Do not raise exceptions in unexpected locations                                                                                              |               |
| [CA1066](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1066) | Implement IEquatable when overriding Equals                                                                                                  |               |
| [CA1067](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1067) | Override Equals when implementing IEquatable                                                                                                 |               |
| [CA1068](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1068) | CancellationToken parameters must come last                                                                                                  |               |
| [CA1069](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1069) | Enums should not have duplicate values                                                                                                       |               |
| [CA1070](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1070) | Do not declare event fields as virtual                                                                                                       |               |

### Microsoft.CodeAnalysis.NetAnalyzers | Documentation

### Microsoft.CodeAnalysis.NetAnalyzers | Globalization

### Microsoft.CodeAnalysis.NetAnalyzers | Interoperability

### Microsoft.CodeAnalysis.NetAnalyzers | Maintainability

### Microsoft.CodeAnalysis.NetAnalyzers | Naming

### Microsoft.CodeAnalysis.NetAnalyzers | Performance

### Microsoft.CodeAnalysis.NetAnalyzers | Reliability

### Microsoft.CodeAnalysis.NetAnalyzers | Security

### Microsoft.CodeAnalysis.NetAnalyzers | Usage
