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
| For locals, parameters, and members (IDE0049)                         | Prefer predefined type    | ⚠ Warning    |
| For member access expressions (IDE0049)                               | Prefer predefined type    | ⚠ Warning    |

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
| When variable type is apparent                                        | Prefer _var_              | ⚠ Warning    |
| Elsewhere                                                             | Prefer _var_              | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_var_for_built_in_types = false:suggestion
csharp_style_var_elsewhere = true:suggestion
csharp_style_var_when_type_is_apparent = true:warning
```

</details>


### Code Style | General | Code block preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer braces (IDE0011)                                               | Yes                       | ⚠ Warning    |
| Namespace declarations                                                | File scoped               | 🛈 Suggestion  |
| Prefer auto properties                                                | Yes                       | 🞅 Refactoring |
| Prefer simple _using_ statement                                       | Yes                       | 🛈 Suggestion  |
| Prefer _System.HashCode_ in 'GetHashCode'                             | Yes                       | 🛈 Suggestion  |
| Prefer method group conversion                                        | Yes                       | 🛈 Suggestion  |
| Prefer top-level statements                                           | Yes                       | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_prefer_braces = true:warning
csharp_style_namespace_declarations = file_scoped:suggestion
csharp_prefer_simple_using_statement = true:suggestion
dotnet_style_prefer_auto_properties = true:silent
# Missing: Prefer _System.HashCode_ in 'GetHashCode'
csharp_style_prefer_method_group_conversion = true:suggestion
csharp_style_prefer_top_level_statements = true:suggestion
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
| Prefer implicit object creation when type is aparent (IDE0090)        | Yes                       | 🛈 Suggestion  |
| Prefer index operator                                                 | Yes                       | 🛈 Suggestion  |
| Prefer range operator                                                 | Yes                       | 🛈 Suggestion  |
| Prefer tuple swap                                                     | Yes                       | 🛈 Suggestion  |
| Avoid unused value assignments                                        | Discard                   | 🞅 Refactoring |
| Avoid expression statements that implicitly ignore value              | Discard                   | 🞅 Refactoring |

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
csharp_style_unused_value_assignment_preference = discard_variable:silent
csharp_style_unused_value_expression_statement_preference = discard_variable:silent
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
| Use expression body for lambdas                                       | When possible             | 🞅 Refactoring |
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
csharp_style_expression_bodied_lambdas = true:silent
csharp_style_expression_bodied_local_functions = false:suggestion
```

</details>


### Code Style | General | Pattern matching preferences
| Description _________________________________________________________ | Preference ______________ | !! Severity !! |
| :-------------------------------------------------------------------- | :------------------------ | :-----------: |
| Prefer pattern matching                                               | Yes                       | 🛈 Suggestion  |
| Prefer pattern matching over _is_ with _cast_ check                   | Yes                       | ⚠ Warning    |
| Prefer pattern matching over _as_ with _null_ check                   | Yes                       | ⚠ Warning    |
| Prefer pattern matching over mixed type check                         | Yes                       | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_prefer_pattern_matching = true:suggestion
csharp_style_pattern_matching_over_is_with_cast_check = true:warning
csharp_style_pattern_matching_over_as_with_null_check = true:warning
csharp_style_prefer_not_pattern = true:warning
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
| Prefer readonly struct                                                | Yes                       | 🛈 Suggestion  |
| Prefer static local functions                                         | Yes                       | ⚠ Warning    |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_readonly_field = true:warning
csharp_style_prefer_readonly_struct = true:suggestion
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
| Allow multiple blank lines (IDE2000)                                  | No                        | ⚠ Warning    |
| Allow embeded statements on same line (IDE2001)                       | No                        | ⚠ Warning    |
| Allow blank lines between consecutive braces (IDE2002)                | No                        | ⚠ Warning    |
| Allow statement immediately after block (IDE2003)                     | No                        | ⚠ Warning    |
| Allow blank line after colon in constructor initializer (IDE2004)     | No                        | ⛔ Error      |
| Allow blank line after token in conditional expression (IDE2005)      | No                        | ⛔ Error      |
| Allow blank line after token in arrow expression clause (IDE2006)     | Yes                       | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_allow_multiple_blank_lines_experimental = false:warning
csharp_style_allow_embedded_statements_on_same_line_experimental = false:warning
csharp_style_allow_blank_lines_between_consecutive_braces_experimental = false:warning
dotnet_style_allow_statement_immediately_after_block_experimental = false:warning
csharp_style_allow_blank_line_after_colon_in_constructor_initializer_experimental = false:error
csharp_style_allow_blank_line_after_token_in_conditional_expression_experimental = false:error
csharp_style_allow_blank_line_after_token_in_arrow_expression_clause_experimental = true:suggestion
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
| Code                                                                                              | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :-----------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1000](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1000) | Do not declare static members on generic types                                                                                           | ⚠ Warning     |
| [CA1001](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1001) | Types that own disposable fields should be disposable                                                                                    | ⚠ Warning     |
| [CA1002](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1002) | Do not expose generic lists                                                                                                              | ⚠ Warning     |
| [CA1003](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1003) | Use generic event handler instances                                                                                                      | 🞅 None         |
| [CA1005](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1005) | Avoid excessive parameters on generic types                                                                                              | ⚠ Warning     |
| [CA1008](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1008) | Enums should have zero value                                                                                                             | ⚠ Warning     |
| [CA1010](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1010) | Collections should implement generic interface                                                                                           | 🛈 Suggestion   |
| [CA1012](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1012) | Abstract types should not have public constructors                                                                                       | ⚠ Warning     |
| [CA1014](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1014) | Mark assemblies with CLSCompliantAttribute                                                                                               | 🞅 None         |
| [CA1016](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1016) | Mark assemblies with AssemblyVersionAttribute                                                                                            | 🞅 None         |
| [CA1017](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1017) | Mark assemblies with ComVisibleAttribute                                                                                                 | 🞅 None         |
| [CA1018](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1018) | Mark attributes with AttributeUsageAttribute                                                                                             | ⚠ Warning     |
| [CA1019](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1019) | Define accessors for attribute arguments                                                                                                 | 🛈 Suggestion   |
| [CA1021](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1021) | Avoid out parameters                                                                                                                     | 🛈 Suggestion   |
| [CA1024](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1024) | Use properties where appropriate                                                                                                         | 🛈 Suggestion   |
| [CA1027](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1027) | Mark enums with FlagsAttribute                                                                                                           | 🛈 Suggestion   |
| [CA1028](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1028) | Enum storage should be Int32                                                                                                             | ⚠ Warning     |
| [CA1030](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1030) | Use events where appropriate                                                                                                             | 🞅 None         |
| [CA1031](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1031) | Do not catch general exception types                                                                                                     | 🛈 Suggestion   |
| [CA1032](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1032) | Implement standard exception constructors                                                                                                | ⚠ Warning     |
| [CA1033](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1033) | Interface methods should be callable by child types                                                                                      | ⚠ Warning     |
| [CA1034](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1034) | Nested types should not be visible                                                                                                       | ⚠ Warning     |
| [CA1036](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1036) | Override methods on comparable types                                                                                                     | 🛈 Suggestion   |
| [CA1040](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1040) | Avoid empty interfaces                                                                                                                   | 🞅 None         |
| [CA1041](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1041) | Provide ObsoleteAttribute message                                                                                                        | ⛔ Error       |
| [CA1043](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1043) | Use integral or string argument for indexers                                                                                             | ⚠ Warning     |
| [CA1044](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1044) | Properties should not be write only                                                                                                      | 🞅 None         |
| [CA1045](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1045) | Do not pass types by reference                                                                                                           | ⚠ Warning     |
| [CA1046](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1046) | Do not overload operator equals on reference types                                                                                       | ⚠ Warning     |
| [CA1047](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1047) | Do not declare protected members in sealed types                                                                                         | 🞅 None         |
| [CA1050](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1050) | Declare types in namespaces                                                                                                              | ⚠ Warning     |
| [CA1051](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1051) | Do not declare visible instance fields                                                                                                   | 🞅 None         |
| [CA1052](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1052) | Static holder types should be Static or NotInheritable                                                                                   | ⛔ Error       |
| [CA1053](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1053) | Static holder types should not have default constructors                                                                                 | -              |CA
| [CA1054](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1054) | URI parameters should not be strings                                                                                                     | ⚠ Warning     |
| [CA1055](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1055) | URI return values should not be strings                                                                                                  | ⚠ Warning     |
| [CA1056](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1056) | URI properties should not be strings                                                                                                     | ⚠ Warning     |
| [CA1058](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1058) | Types should not extend certain base types                                                                                               | ⚠ Warning     |
| [CA1060](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1060) | Move P/Invokes to NativeMethods class                                                                                                    | 🞅 None         |
| [CA1061](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1061) | Do not hide base class methods                                                                                                           | ⚠ Warning     |
| [CA1062](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1062) | Validate arguments of public methods                                                                                                     | 🞅 None         |
| [CA1063](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1063) | Implement IDisposable correctly                                                                                                          | ⚠ Warning     |
| [CA1064](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1064) | Exceptions should be public                                                                                                              | ⛔ Error       |
| [CA1065](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1065) | Do not raise exceptions in unexpected locations                                                                                          | ⛔ Error       |
| [CA1066](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1066) | Implement IEquatable when overriding Equals                                                                                              | ⚠ Warning     |
| [CA1067](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1067) | Override Equals when implementing IEquatable                                                                                             | ⚠ Warning     |
| [CA1068](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1068) | CancellationToken parameters must come last                                                                                              | ⚠ Warning     |
| [CA1069](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1069) | Enums should not have duplicate values                                                                                                   | ⚠ Warning     |
| [CA1070](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1070) | Do not declare event fields as virtual                                                                                                   | 🛈 Suggestion   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1000.severity = warning
dotnet_diagnostic.CA1001.severity = warning
dotnet_diagnostic.CA1002.severity = warning
dotnet_diagnostic.CA1003.severity = none
dotnet_diagnostic.CA1005.severity = warning
dotnet_diagnostic.CA1008.severity = warning
dotnet_diagnostic.CA1010.severity = suggestion
dotnet_diagnostic.CA1012.severity = warning
dotnet_diagnostic.CA1014.severity = none
dotnet_diagnostic.CA1016.severity = none
dotnet_diagnostic.CA1017.severity = none
dotnet_diagnostic.CA1018.severity = warning
dotnet_diagnostic.CA1019.severity = suggestion
dotnet_diagnostic.CA1021.severity = suggestion
dotnet_diagnostic.CA1024.severity = suggestion
dotnet_diagnostic.CA1027.severity = suggestion
dotnet_diagnostic.CA1028.severity = warning
dotnet_diagnostic.CA1030.severity = none
dotnet_diagnostic.CA1031.severity = suggestion
dotnet_diagnostic.CA1032.severity = warning
dotnet_diagnostic.CA1033.severity = warning
dotnet_diagnostic.CA1034.severity = warning
dotnet_diagnostic.CA1036.severity = suggestion
dotnet_diagnostic.CA1040.severity = none
dotnet_diagnostic.CA1041.severity = error
dotnet_diagnostic.CA1043.severity = warning
dotnet_diagnostic.CA1044.severity = none
dotnet_diagnostic.CA1045.severity = warning
dotnet_diagnostic.CA1046.severity = warning
dotnet_diagnostic.CA1047.severity = none
dotnet_diagnostic.CA1050.severity = warning
dotnet_diagnostic.CA1051.severity = error
dotnet_diagnostic.CA1052.severity = error
#dotnet_diagnostic.CA1053.severity = warning
dotnet_diagnostic.CA1054.severity = warning
dotnet_diagnostic.CA1055.severity = warning
dotnet_diagnostic.CA1056.severity = warning
dotnet_diagnostic.CA1058.severity = warning
dotnet_diagnostic.CA1060.severity = none
dotnet_diagnostic.CA1061.severity = warning
dotnet_diagnostic.CA1062.severity = none
dotnet_diagnostic.CA1063.severity = warning
dotnet_diagnostic.CA1064.severity = error
dotnet_diagnostic.CA1065.severity = error
dotnet_diagnostic.CA1066.severity = warning
dotnet_diagnostic.CA1067.severity = warning
dotnet_diagnostic.CA1068.severity = warning
dotnet_diagnostic.CA1069.severity = warning
dotnet_diagnostic.CA1070.severity = suggestion
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Documentation
| Code                                                                                              | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :-----------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1200](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1200) | Avoid using cref tags with a prefix                                                                                                      | 🞅 None         |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1200.severity = none
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Globalization
| Code                                                                                              | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :-----------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1303](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1303) | Do not pass literals as localized parameters                                                                                             | ⚠ Warning     |
| [CA1304](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1304) | Specify CultureInfo                                                                                                                      | ⚠ Warning     |
| [CA1305](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1305) | Specify IFormatProvider                                                                                                                  | ⚠ Warning     |
| [CA1307](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1307) | Specify StringComparison for clarity                                                                                                     | ⚠ Warning     |
| [CA1308](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1308) | Normalize strings to uppercase                                                                                                           | 🛈 Suggestion   |
| [CA1309](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1309) | Use ordinal StringComparison                                                                                                             | ⚠ Warning     |
| [CA1310](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1310) | Specify StringComparison for correctness                                                                                                 | ⚠ Warning     |
| [CA1311](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1311) | Specify a culture or use an invariant version                                                                                            | ⚠ Warning     |
| [CA2101](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2101) | Specify marshalling for P/Invoke string arguments                                                                                        | 🛈 Suggestion   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1303.severity = warning
dotnet_diagnostic.CA1304.severity = warning
dotnet_diagnostic.CA1305.severity = warning
dotnet_diagnostic.CA1307.severity = warning
dotnet_diagnostic.CA1308.severity = suggestion
dotnet_diagnostic.CA1309.severity = warning
dotnet_diagnostic.CA1310.severity = warning
dotnet_diagnostic.CA1311.severity = warning
dotnet_diagnostic.CA2101.severity = suggestion
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Interoperability
| Code                                                                                               | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1401](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1401)  | P/Invokes should not be visible                                                                                                          | 🛈 Suggestion   |
| [CA1416](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1416)  | Validate platform compatibility                                                                                                          | ⚠ Warning     |
| [CA1417](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1417)  | Do not use _OutAttribute_ on string parameters for P/Invokes                                                                             | ⚠ Warning     |
| [CA1418](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1418)  | Validate platform compatibility                                                                                                          | ⚠ Warning     |
| [CA1419](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1419)  | Provide a parameterless ctor for types derived from                                    <br /> _System.Runtime.InteropServices.SafeHandle_| 🛈 Suggestion   |
| [CA1420](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1420) | Property, type, or attribute requires runtime marshalling                                                                                | ⚠ Warning     |
| [CA1421](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1421) | Method uses runtime marshalling when *DisableRuntimeMarshalling* is applied                                                              | 🛈 Suggestion   |
| [CA1422](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1422) | Validate platform compatibility - Obsoleted APIs                                                                                         | ⚠ Warning     |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1401.severity = suggestion
dotnet_diagnostic.CA1416.severity = warning
dotnet_diagnostic.CA1417.severity = warning
dotnet_diagnostic.CA1418.severity = warning
dotnet_diagnostic.CA1419.severity = suggestion
dotnet_diagnostic.CA1420.severity = warning
dotnet_diagnostic.CA1421.severity = suggestion
dotnet_diagnostic.CA1422.severity = warning
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Maintainability
| Code                                                                                              | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :-----------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1501](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1501) | Avoid excessive inheritance                                                                                                              | ⚠ Warning     |
| [CA1502](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1502) | Avoid excessive complexity                                                                                                               | ⚠ Warning     |
| [CA1505](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1505) | Avoid unmaintainable code                                                                                                                | ⚠ Warning     |
| [CA1506](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1506) | Avoid excessive class coupling                                                                                                           | ⚠ Warning     |
| [CA1507](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1507) | Use _nameof_ in place of string                                                                                                          | ⚠ Warning     |
| [CA1508](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1508) | Avoid dead conditional code                                                                                                              | ⚠ Warning     |
| [CA1509](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1509) | Invalid entry in code metrics configuration file                                                                                         | ⛔ Error       |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1501.severity = warning
dotnet_diagnostic.CA1502.severity = warning
dotnet_diagnostic.CA1505.severity = warning
dotnet_diagnostic.CA1506.severity = warning
dotnet_diagnostic.CA1507.severity = warning
dotnet_diagnostic.CA1508.severity = warning
dotnet_diagnostic.CA1509.severity = error 
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Naming
| Code                                                                                              | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :-----------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1700](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1700) | Do not name enum values _Reserved_                                                                                                       | 🛈 Suggestion   |
| [CA1707](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1707) | Identifiers should not contain underscores                                                                                               | ⛔ Error       |
| [CA1708](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1708) | Identifiers should differ by more than case                                                                                              | 🛈 Suggestion   |
| [CA1710](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1710) | Identifiers should have correct suffix                                                                                                   | ⚠ Warning     |
| [CA1711](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1711) | Identifiers should not have incorrect suffix                                                                                             | ⚠ Warning     |
| [CA1712](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1712) | Do not prefix enum values with type name                                                                                                 | ⛔ Error       |
| [CA1713](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1713) | Events should not have before or after prefix                                                                                            | ⚠ Warning     |
| [CA1714](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1714) | Flags enums should have plural names                                                                                                     | ⚠ Warning     |
| [CA1715](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1715) | Identifiers should have correct prefix                                                                                                   | ⚠ Warning     |
| [CA1716](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1716) | Identifiers should not match keywords                                                                                                    | ⚠ Warning     |
| [CA1717](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1717) | Only _FlagsAttribute_ enums should have plural names                                                                                     | 🛈 Suggestion   |
| [CA1721](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1721) | Property names should not match get methods                                                                                              | ⚠ Warning     |
| [CA1720](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1720) | Identifiers should not contain type names                                                                                                | ⚠ Warning     |
| [CA1724](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1724) | Type names should not match namespaces                                                                                                   | ⚠ Warning     |
| [CA1725](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1725) | Parameter names should match base declaration                                                                                            | ⚠ Warning     |
| [CA1727](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1727) | Use PascalCase for named placeholders                                                                                                    | ⚠ Warning     |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1700.severity = suggestion
dotnet_diagnostic.CA1707.severity = error
dotnet_diagnostic.CA1708.severity = suggestion
dotnet_diagnostic.CA1710.severity = warning
dotnet_diagnostic.CA1711.severity = warning
dotnet_diagnostic.CA1712.severity = error
dotnet_diagnostic.CA1713.severity = warning
dotnet_diagnostic.CA1714.severity = warning
dotnet_diagnostic.CA1715.severity = warning
dotnet_diagnostic.CA1716.severity = warning
dotnet_diagnostic.CA1717.severity = suggestion
dotnet_diagnostic.CA1720.severity = warning
dotnet_diagnostic.CA1721.severity = warning
dotnet_diagnostic.CA1724.severity = warning
dotnet_diagnostic.CA1725.severity = warning
dotnet_diagnostic.CA1727.severity = warning
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Performance
| Code                                                                                               | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1802](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1802)  | Use literals where appropriate                                                                                                           | ⚠ Warning     |
| [CA1805](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1805)  | Do not initialize unnecessarily                                                                                                          | ⚠ Warning     |
| [CA1806](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1806)  | Do not ignore method results                                                                                                             | ⚠ Warning     |
| [CA1810](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1810)  | Initialize reference type static fields inline                                                                                           | ⚠ Warning     |
| [CA1812](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1812)  | Avoid uninstantiated internal classes                                                                                                    | ⚠ Warning     |
| [CA1813](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1813)  | Avoid unsealed attributes                                                                                                                | ⛔ Error       |
| [CA1814](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1814)  | Prefer jagged arrays over multidimensional                                                                                               | 🛈 Suggestion   |
| [CA1815](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1815)  | Override equals and operator equals on value types                                                                                       | ⚠ Warning     |
| [CA1819](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1819)  | Properties should not return arrays                                                                                                      | ⚠ Warning     |
| [CA1820](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1820)  | Test for empty strings using string length                                                                                               | ⚠ Warning     |
| [CA1821](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1821)  | Remove empty finalizers                                                                                                                  | ⚠ Warning     |
| [CA1822](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1822)  | Mark members as static                                                                                                                   | ⚠ Warning     |
| [CA1823](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1823)  | Avoid unused private fields                                                                                                              | ⚠ Warning     |
| [CA1824](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1824)  | Mark assemblies with _NeutralResourcesLanguageAttribute_                                                                                 | 🞅 None         |
| [CA1825](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1825)  | Avoid zero-length array allocations                                                                                                      | ⚠ Warning     |
| [CA1826](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1826)  | Use property instead of Linq Enumerable method                                                                                           | ⚠ Warning     |
| [CA1827](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1827)  | Do not use _Count_/_LongCount_ when _Any_ can be used                                                                                    | ⚠ Warning     |
| [CA1828](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1828)  | Do not use _CountAsync_/_LongCountAsync_ when _AnyAsync_ can be used                                                                     | ⚠ Warning     |
| [CA1829](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1829)  | Use _Length_/_Count_ property instead of _Enumerable.Count_ method                                                                       | ⚠ Warning     |
| [CA1830](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1830)  | Prefer strongly-typed _Append_ and _Insert_ method overloads on _StringBuilder_                                                          | ⚠ Warning     |
| [CA1831](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1831)  | Use _AsSpan_ instead of Range-based indexers for string when appropriate                                                                 | 🛈 Suggestion   |
| [CA1832](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1832)  | Use _AsSpan_ or _AsMemory_ instead of Range-based indexers for getting                 <br /> ReadOnlySpan or ReadOnlyMemory [..]        | 🛈 Suggestion   |
| [CA1833](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1833)  | Use _AsSpan_ or _AsMemory_ instead of Range-based indexers for getting                 <br /> Span or Memory [..]                        | 🛈 Suggestion   |
| [CA1834](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1834)  | Use _StringBuilder.Append(char)_ for single character strings                                                                            | ⚠ Warning     |
| [CA1835](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1835)  | Prefer the memory-based overloads of _ReadAsync_/_WriteAsync_ methods [..]                                                               | 🛈 Suggestion   |
| [CA1836](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1836)  | Prefer _IsEmpty_ over _Count_ when available                                                                                             | ⚠ Warning     |
| [CA1837](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1837)  | Use _Environment.ProcessId_ instead of _Process.GetCurrentProcess().Id_                                                                  | 🛈 Suggestion   |
| [CA1838](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1838)  | Avoid StringBuilder parameters for P/Invokes                                                                                             | 🛈 Suggestion   |
| [CA1839](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1839)  | Use _Environment.ProcessPath_ [..]                                                                                                       | 🛈 Suggestion   |
| [CA1840](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1840)  | Use _Environment.CurrentManagedThreadId_ [..]                                                                                            | 🛈 Suggestion   |
| [CA1841](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1841)  | Prefer Dictionary Contains methods                                                                                                       | ⚠ Warning     |
| [CA1842](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1842)  | Do not use _WhenAll_ with a single task                                                                                                  | ⛔ Error       |
| [CA1843](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1843)  | Do not use _WaitAll_ with a single task                                                                                                  | ⛔ Error       |
| [CA1844](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1844)  | Provide memory-based overrides of async methods when subclassing _Stream_                                                                | ⚠ Warning     |
| [CA1845](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1845)  | Use span-based _string.Concat_                                                                                                           | ⚠ Warning     |
| [CA1846](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1846)  | Prefer _AsSpan_ over _Substring_                                                                                                         | ⚠ Warning     |
| [CA1847](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1847)  | Use _string.Contains(char)_ instead of _string.Contains(string)_ with single chars                                                       | ⚠ Warning     |
| [CA1848](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1848)  | Use the LoggerMessage delegates                                                                                                          | 🛈 Suggestion   |
| [CA1849](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1849)  | Call async methods when in an async method                                                                                               | ⚠ Warning     |
| [CA1850](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1850)  | Prefer static _HashData_ method over _ComputeHash_                                                                                       | 🞅 None         |
| [CA1851](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1851)  | Possible multiple enumerations of IEnumerable collection                                                                                 | ⚠ Warning     |
| [CA1852](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1852) | Seal internal types                                                                                                                      | ⚠ Warning     |
| [CA1853](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1853) | Unnecessary call to *Dictionary.ContainsKey(key)*                                                                                        | ⚠ Warning     |
| [CA1854](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1854) | Prefer the *IDictionary.TryGetValue(TKey, out TValue)* method                                                                            | 🛈 Suggestion   |
| [CA1855](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1855) | Use *Span[T].Clear()* instead of *Span[T].Fill()*                                                                                        | 🛈 Suggestion   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1802.severity = warning
dotnet_diagnostic.CA1805.severity = warning
dotnet_diagnostic.CA1806.severity = warning
dotnet_diagnostic.CA1810.severity = warning
dotnet_diagnostic.CA1812.severity = warning
dotnet_diagnostic.CA1813.severity = error
dotnet_diagnostic.CA1814.severity = suggestion
dotnet_diagnostic.CA1815.severity = warning
dotnet_diagnostic.CA1819.severity = warning
dotnet_diagnostic.CA1820.severity = warning
dotnet_diagnostic.CA1821.severity = warning
dotnet_diagnostic.CA1822.severity = warning
dotnet_diagnostic.CA1823.severity = warning
dotnet_diagnostic.CA1824.severity = none
dotnet_diagnostic.CA1825.severity = warning
dotnet_diagnostic.CA1826.severity = warning
dotnet_diagnostic.CA1827.severity = warning
dotnet_diagnostic.CA1828.severity = warning
dotnet_diagnostic.CA1829.severity = warning
dotnet_diagnostic.CA1830.severity = warning
dotnet_diagnostic.CA1831.severity = suggestion
dotnet_diagnostic.CA1832.severity = suggestion
dotnet_diagnostic.CA1833.severity = suggestion
dotnet_diagnostic.CA1834.severity = warning
dotnet_diagnostic.CA1835.severity = suggestion
dotnet_diagnostic.CA1836.severity = warning
dotnet_diagnostic.CA1837.severity = suggestion
dotnet_diagnostic.CA1838.severity = suggestion
dotnet_diagnostic.CA1839.severity = suggestion
dotnet_diagnostic.CA1840.severity = suggestion
dotnet_diagnostic.CA1841.severity = warning
dotnet_diagnostic.CA1842.severity = error
dotnet_diagnostic.CA1843.severity = error
dotnet_diagnostic.CA1844.severity = warning
dotnet_diagnostic.CA1845.severity = warning
dotnet_diagnostic.CA1846.severity = warning
dotnet_diagnostic.CA1847.severity = warning
dotnet_diagnostic.CA1848.severity = suggestion
dotnet_diagnostic.CA1849.severity = warning
dotnet_diagnostic.CA1850.severity = none
dotnet_diagnostic.CA1851.severity = warning
dotnet_diagnostic.CA1852.severity = warning
dotnet_diagnostic.CA1853.severity = warning
dotnet_diagnostic.CA1854.severity = suggestion
dotnet_diagnostic.CA1855.severity = suggestion
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Reliability
| Code                                                                                               | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA2000](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2000)  | Dispose objects before losing scope                                                                                                      | 🛈 Suggestion   |
| [CA2002](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2002)  | Do not lock on objects with weak identity                                                                                                | ⛔ Error       |
| [CA2007](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2007)  | Do not directly await a Task                                                                                                             | 🛈 Suggestion   |
| [CA2008](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2008)  | Do not create tasks without passing a _TaskScheduler_                                                                                    | 🛈 Suggestion   |
| [CA2009](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2009)  | Do not call _ToImmutableCollection_ on an _ImmutableCollection_ value                                                                    | ⚠ Warning     |
| [CA2011](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2011)  | Do not assign property within its setter                                                                                                 | ⛔ Error       |
| [CA2012](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2012)  | Use _ValueTasks_ correctly                                                                                                               | 🛈 Suggestion   |
| [CA2013](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2013)  | Do not use _ReferenceEquals_ with value types                                                                                            | ⚠ Warning     |
| [CA2014](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2014)  | Do not use _stackalloc_ in loops                                                                                                         | ⚠ Warning     |
| [CA2015](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2015)  | Do not define finalizers for types derived from _MemoryManager<T>_                                                                       | ⚠ Warning     |
| [CA2016](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2016)  | Forward the _CancellationToken_ parameter to methods that take one                                                                       | ⚠ Warning     |
| [CA2017](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2017)  | Parameter count mismatch                                                                                                                 | ⚠ Warning     |
| [CA2018](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2018)  | The count argument to _Buffer.BlockCopy_ should specify the number of bytes [..]                                                         | ⚠ Warning     |
| [CA2019](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2019) | *ThreadStatic* fields should not use inline initialization                                                                               | 🛈 Suggestion   |
| [CA2020](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2020) | Prevent behavioral change caused by built-in operators of *IntPtr/UIntPtr*                                                               | 🛈 Suggestion   |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA2000.severity = suggestion
dotnet_diagnostic.CA2002.severity = error
dotnet_diagnostic.CA2007.severity = suggestion
dotnet_diagnostic.CA2008.severity = suggestion
dotnet_diagnostic.CA2009.severity = warning
dotnet_diagnostic.CA2011.severity = error
dotnet_diagnostic.CA2012.severity = suggestion
dotnet_diagnostic.CA2013.severity = warning
dotnet_diagnostic.CA2014.severity = warning
dotnet_diagnostic.CA2015.severity = warning
dotnet_diagnostic.CA2016.severity = warning
dotnet_diagnostic.CA2017.severity = warning
dotnet_diagnostic.CA2018.severity = warning
dotnet_diagnostic.CA2019.severity = suggestion
dotnet_diagnostic.CA2020.severity = suggestion
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Security
| Code                                                                                              | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :-----------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA2100](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2100) | Review SQL queries for security vulnerabilities                                                                                          | ⚠ Warning     |
| [CA2109](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2109) | Review visible event handlers                                                                                                            | ⚠ Warning     |
| [CA2119](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2119) | Seal methods that satisfy private interfaces                                                                                             | ⚠ Warning     |
| [CA2153](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2153) | Avoid handling Corrupted State Exceptions                                                                                                | ⚠ Warning     |
| [CA2300](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2300) | Do not use insecure deserializer BinaryFormatter                                                                                         | ⛔ Error       |
| [CA2301](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2301) | Do not call BinaryFormatter.Deserialize without first setting BinaryFormatter.Binder                                                     | 🞅 None         |
| [CA2302](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2302) | Ensure BinaryFormatter.Binder is set before calling BinaryFormatter.Deserialize                                                          | 🞅 None         |
| [CA2305](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2305) | Do not use insecure deserializer LosFormatter                                                                                            | ⛔ Error       |
| [CA2310](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2310) | Do not use insecure deserializer NetDataContractSerializer                                                                               | ⛔ Error       |
| [CA2311](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2311) | Do not deserialize without first setting NetDataContractSerializer.Binder                                                                | 🞅 None         |
| [CA2312](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2312) | Ensure NetDataContractSerializer.Binder is set before deserializing                                                                      | 🞅 None         |
| [CA2315](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2315) | Do not use insecure deserializer ObjectStateFormatter                                                                                    | ⛔ Error       |
| [CA2321](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2321) | Do not deserialize with JavaScriptSerializer using a SimpleTypeResolver                                                                  | ⚠ Warning     |
| [CA2322](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2322) | Ensure JavaScriptSerializer is not initialized with SimpleTypeResolver [..]                                                              | ⚠ Warning     |
| [CA2326](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2326) | Do not use TypeNameHandling values other than None                                                                                       | ⚠ Warning     |
| [CA2327](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2327) | Do not use insecure JsonSerializerSettings                                                                                               | ⚠ Warning     |
| [CA2328](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2328) | Ensure that JsonSerializerSettings are secure                                                                                            | ⚠ Warning     |
| [CA2329](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2329) | Do not deserialize with JsonSerializer using an insecure configuration                                                                   | ⚠ Warning     |
| [CA2330](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2330) | Ensure that JsonSerializer has a secure configuration when deserializing                                                                 | ⚠ Warning     |
| [CA2350](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2350) | Ensure DataTable.ReadXml()'s input is trusted                                                                                            | ⚠ Warning     |
| [CA2351](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2351) | Ensure DataSet.ReadXml()'s input is trusted                                                                                              | ⚠ Warning     |
| [CA2352](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2352) | Unsafe DataSet or DataTable in serializable type can be vulnerable to RCEA                                                               | ⚠ Warning     |
| [CA2353](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2353) | Unsafe DataSet or DataTable in serializable type                                                                                         | ⚠ Warning     |
| [CA2354](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2354) | Unsafe DataSet or DataTable in deserialized object graph can be vulnerable to RCEA                                                       | ⚠ Warning     |
| [CA2355](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2355) | Unsafe DataSet or DataTable in deserialized object graph                                                                                 | ⚠ Warning     |
| [CA2356](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2356) | Unsafe DataSet or DataTable type in web deserialized object graph                                                                        | ⚠ Warning     |
| [CA2361](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2361) | Ensure autogen class with DataSet.ReadXml() is not used with untrusted data                                                              | ⚠ Warning     |
| [CA2362](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2362) | Unsafe DataSet or DataTable in autogen serializable type can be vulnerable to RCEA                                                       | ⚠ Warning     |
| [CA3001](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3001) | Review code for SQL injection vulnerabilities                                                                                            | ⚠ Warning     |
| [CA3002](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3002) | Review code for XSS vulnerabilities                                                                                                      | ⚠ Warning     |
| [CA3003](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3003) | Review code for file path injection vulnerabilities                                                                                      | ⚠ Warning     |
| [CA3004](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3004) | Review code for information disclosure vulnerabilities                                                                                   | ⚠ Warning     |
| [CA3005](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3005) | Review code for LDAP injection vulnerabilities                                                                                           | ⚠ Warning     |
| [CA3006](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3006) | Review code for process command injection vulnerabilities                                                                                | ⚠ Warning     |
| [CA3007](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3007) | Review code for open redirect vulnerabilities                                                                                            | ⚠ Warning     |
| [CA3008](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3008) | Review code for XPath injection vulnerabilities                                                                                          | ⚠ Warning     |
| [CA3009](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3009) | Review code for XML injection vulnerabilities                                                                                            | ⚠ Warning     |
| [CA3010](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3010) | Review code for XAML injection vulnerabilities                                                                                           | ⚠ Warning     |
| [CA3011](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3011) | Review code for DLL injection vulnerabilities                                                                                            | ⚠ Warning     |
| [CA3012](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3012) | Review code for regex injection vulnerabilities                                                                                          | ⚠ Warning     |
| [CA3061](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3061) | Do not add schema by URL                                                                                                                 | ⚠ Warning     |
| [CA3075](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3075) | Insecure DTD Processing                                                                                                                  | ⚠ Warning     |
| [CA3076](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3076) | Insecure XSLT Script Execution                                                                                                           | ⚠ Warning     |
| [CA3077](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3077) | Insecure Processing in API Design, XML Document and XML Text Reader                                                                      | ⚠ Warning     |
| [CA3147](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca3147) | Mark verb handlers with ValidateAntiForgeryToken                                                                                         | ⚠ Warning     |
| [CA5350](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5350) | Do Not Use Weak Cryptographic Algorithms                                                                                                 | ⚠ Warning     |
| [CA5351](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5351) | Do Not Use Broken Cryptographic Algorithms                                                                                               | ⚠ Warning     |
| [CA5358](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5358) | Do Not Use Unsafe Cipher Modes                                                                                                           | ⚠ Warning     |
| [CA5359](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5359) | Do not disable certificate validation                                                                                                    | ⚠ Warning     |
| [CA5360](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5360) | Do not call dangerous methods in deserialization                                                                                         | ⚠ Warning     |
| [CA5361](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5361) | Do not disable SChannel use of strong crypto                                                                                             | ⚠ Warning     |
| [CA5362](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5362) | Potential reference cycle in deserialized object graph                                                                                   | 🛈 Suggestion   |
| [CA5363](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5363) | Do not disable request validation                                                                                                        | ⚠ Warning     |
| [CA5364](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5364) | Do not use deprecated security protocols                                                                                                 | ⚠ Warning     |
| [CA5365](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5365) | Do Not Disable HTTP Header Checking                                                                                                      | ⚠ Warning     |
| [CA5366](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5366) | Use XmlReader For DataSet Read XML                                                                                                       | ⚠ Warning     |
| [CA5367](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5367) | Do not serialize types with pointer fields                                                                                               | ⛔ Error       |
| [CA5368](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5368) | Set ViewStateUserKey For Classes Derived From Page                                                                                       | ⚠ Warning     |
| [CA5369](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5369) | Use XmlReader for Deserialize                                                                                                            | ⚠ Warning     |
| [CA5370](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5370) | Use XmlReader for validating reader                                                                                                      | ⚠ Warning     |
| [CA5371](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5371) | Use XmlReader for schema read                                                                                                            | ⚠ Warning     |
| [CA5372](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5372) | Use XmlReader for XPathDocument                                                                                                          | ⚠ Warning     |
| [CA5373](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5373) | Do not use obsolete key derivation function                                                                                              | ⚠ Warning     |
| [CA5374](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5374) | Do not use XslTransform                                                                                                                  | ⚠ Warning     |
| [CA5375](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5375) | Do not use account shared access signature                                                                                               | ⚠ Warning     |
| [CA5376](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5376) | Use SharedAccessProtocol HttpsOnly                                                                                                       | ⚠ Warning     |
| [CA5377](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5377) | Use container level access policy                                                                                                        | ⚠ Warning     |
| [CA5378](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5378) | Do not disable ServicePointManagerSecurityProtocols                                                                                      | ⚠ Warning     |
| [CA5379](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5379) | Ensure key derivation function algorithm is sufficiently strong                                                                          | ⚠ Warning     |
| [CA5380](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5380) | Do not add certificates to root store                                                                                                    | ⚠ Warning     |
| [CA5381](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5381) | Ensure certificates are not added to root store                                                                                          | ⚠ Warning     |
| [CA5382](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5382) | Use secure cookies in ASP.NET Core                                                                                                       | ⚠ Warning     |
| [CA5383](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5383) | Ensure use secure cookies in ASP.NET Core                                                                                                | ⚠ Warning     |
| [CA5384](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5384) | Do not use digital signature algorithm (DSA)                                                                                             | ⚠ Warning     |
| [CA5385](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5385) | Use Rivest–Shamir–Adleman (RSA) algorithm with sufficient key size                                                                       | ⚠ Warning     |
| [CA5386](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5386) | Avoid hardcoding SecurityProtocolType value                                                                                              | ⚠ Warning     |
| [CA5387](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5387) | Do not use weak key derivation function with insufficient iteration count                                                                | ⚠ Warning     |
| [CA5388](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5388) | Ensure sufficient iteration count when using weak key derivation function                                                                | ⚠ Warning     |
| [CA5389](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5389) | Do not add archive item's path to the target file system path                                                                            | ⚠ Warning     |
| [CA5390](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5390) | Do not hard-code encryption key                                                                                                          | ⚠ Warning     |
| [CA5391](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5391) | Use antiforgery tokens in ASP.NET Core MVC controllers                                                                                   | ⚠ Warning     |
| [CA5392](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5392) | Use DefaultDllImportSearchPaths attribute for P/Invokes                                                                                  | 🞅 None         |
| [CA5393](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5393) | Do not use unsafe DllImportSearchPath value                                                                                              | 🞅 None         |
| [CA5394](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5394) | Do not use insecure randomness                                                                                                           | ⚠ Warning     |
| [CA5395](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5395) | Miss HttpVerb attribute for action methods                                                                                               | ⛔ Error       |
| [CA5396](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5396) | Set HttpOnly to true for HttpCookie                                                                                                      | ⚠ Warning     |
| [CA5397](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5397) | Do not use deprecated SslProtocols values                                                                                                | ⚠ Warning     |
| [CA5398](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5398) | Avoid hardcoded SslProtocols values                                                                                                      | ⛔ Error       |
| [CA5399](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5399) | Enable HttpClient certificate revocation list check                                                                                      | ⚠ Warning     |
| [CA5400](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5400) | Ensure HttpClient certificate revocation list check is not disabled                                                                      | ⚠ Warning     |
| [CA5401](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5401) | Do not use CreateEncryptor with non-default IV                                                                                           | ⚠ Warning     |
| [CA5402](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5402) | Use CreateEncryptor with the default IV                                                                                                  | ⚠ Warning     |
| [CA5403](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5403) | Do not hard-code certificate                                                                                                             | ⛔ Error       |
| [CA5404](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5404) | Do not disable token validation checks                                                                                                   | ⚠ Warning     |
| [CA5405](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5405) | Do not always skip token validation in delegates                                                                                         | ⚠ Warning     |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA2100.severity = warning
dotnet_diagnostic.CA2109.severity = warning
dotnet_diagnostic.CA2119.severity = warning
dotnet_diagnostic.CA2153.severity = warning
dotnet_diagnostic.CA2300.severity = error
dotnet_diagnostic.CA2301.severity = none
dotnet_diagnostic.CA2302.severity = none
dotnet_diagnostic.CA2305.severity = error
dotnet_diagnostic.CA2310.severity = error
dotnet_diagnostic.CA2311.severity = none
dotnet_diagnostic.CA2312.severity = none
dotnet_diagnostic.CA2315.severity = error
dotnet_diagnostic.CA2321.severity = warning
dotnet_diagnostic.CA2322.severity = warning
dotnet_diagnostic.CA2326.severity = warning
dotnet_diagnostic.CA2327.severity = warning
dotnet_diagnostic.CA2328.severity = warning
dotnet_diagnostic.CA2329.severity = warning
dotnet_diagnostic.CA2330.severity = warning
dotnet_diagnostic.CA2350.severity = warning
dotnet_diagnostic.CA2351.severity = warning
dotnet_diagnostic.CA2352.severity = warning
dotnet_diagnostic.CA2353.severity = warning
dotnet_diagnostic.CA2354.severity = warning
dotnet_diagnostic.CA2355.severity = warning
dotnet_diagnostic.CA2356.severity = warning
dotnet_diagnostic.CA2361.severity = warning
dotnet_diagnostic.CA2362.severity = warning
dotnet_diagnostic.CA3001.severity = warning
dotnet_diagnostic.CA3002.severity = warning
dotnet_diagnostic.CA3003.severity = warning
dotnet_diagnostic.CA3004.severity = warning
dotnet_diagnostic.CA3005.severity = warning
dotnet_diagnostic.CA3006.severity = warning
dotnet_diagnostic.CA3007.severity = warning
dotnet_diagnostic.CA3008.severity = warning
dotnet_diagnostic.CA3009.severity = warning
dotnet_diagnostic.CA3010.severity = warning
dotnet_diagnostic.CA3011.severity = warning
dotnet_diagnostic.CA3012.severity = warning
dotnet_diagnostic.CA3061.severity = warning
dotnet_diagnostic.CA3075.severity = warning
dotnet_diagnostic.CA3076.severity = warning
dotnet_diagnostic.CA3077.severity = warning
dotnet_diagnostic.CA3147.severity = warning
dotnet_diagnostic.CA5350.severity = warning
dotnet_diagnostic.CA5351.severity = warning
dotnet_diagnostic.CA5358.severity = warning
dotnet_diagnostic.CA5359.severity = warning
dotnet_diagnostic.CA5360.severity = warning
dotnet_diagnostic.CA5361.severity = warning
dotnet_diagnostic.CA5362.severity = suggestion 
dotnet_diagnostic.CA5363.severity = warning
dotnet_diagnostic.CA5364.severity = warning
dotnet_diagnostic.CA5365.severity = warning
dotnet_diagnostic.CA5366.severity = warning
dotnet_diagnostic.CA5367.severity = error 
dotnet_diagnostic.CA5368.severity = warning
dotnet_diagnostic.CA5369.severity = warning
dotnet_diagnostic.CA5370.severity = warning
dotnet_diagnostic.CA5371.severity = warning
dotnet_diagnostic.CA5372.severity = warning
dotnet_diagnostic.CA5373.severity = warning
dotnet_diagnostic.CA5374.severity = warning
dotnet_diagnostic.CA5375.severity = warning
dotnet_diagnostic.CA5376.severity = warning
dotnet_diagnostic.CA5377.severity = warning
dotnet_diagnostic.CA5378.severity = warning
dotnet_diagnostic.CA5379.severity = warning
dotnet_diagnostic.CA5380.severity = warning
dotnet_diagnostic.CA5381.severity = warning
dotnet_diagnostic.CA5382.severity = warning
dotnet_diagnostic.CA5383.severity = warning
dotnet_diagnostic.CA5384.severity = warning
dotnet_diagnostic.CA5385.severity = warning
dotnet_diagnostic.CA5386.severity = warning
dotnet_diagnostic.CA5387.severity = warning
dotnet_diagnostic.CA5388.severity = warning
dotnet_diagnostic.CA5389.severity = warning
dotnet_diagnostic.CA5390.severity = warning
dotnet_diagnostic.CA5391.severity = warning
dotnet_diagnostic.CA5392.severity = none
dotnet_diagnostic.CA5393.severity = none
dotnet_diagnostic.CA5394.severity = warning
dotnet_diagnostic.CA5395.severity = error
dotnet_diagnostic.CA5396.severity = warning
dotnet_diagnostic.CA5397.severity = warning
dotnet_diagnostic.CA5398.severity = error
dotnet_diagnostic.CA5399.severity = warning
dotnet_diagnostic.CA5400.severity = warning
dotnet_diagnostic.CA5401.severity = warning
dotnet_diagnostic.CA5402.severity = warning
dotnet_diagnostic.CA5403.severity = error
dotnet_diagnostic.CA5404.severity = warning
dotnet_diagnostic.CA5405.severity = warning
```

</details>

### Microsoft.CodeAnalysis.NetAnalyzers | Usage
| Code                                                                                               | Description ___________________________________________________________________________                                                  | !! Severity !! |
| :------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------- | :------------: |
| [CA1816](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1816)  | Call GC.SuppressFinalize correctly                                                                                                       | 🛈 Suggestion   |
| [CA2200](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2200)  | Rethrow to preserve stack details                                                                                                        | ⚠ Warning     |
| [CA2201](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2201)  | Do not raise reserved exception types                                                                                                    | ⚠ Warning     |
| [CA2207](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2207)  | Initialize value type static fields inline                                                                                               | ⚠ Warning     |
| [CA2208](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2208)  | Instantiate argument exceptions correctly                                                                                                | ⚠ Warning     |
| [CA2211](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2211)  | Non-constant fields should not be visible                                                                                                | ⚠ Warning     |
| [CA2213](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2213)  | Disposable fields should be disposed                                                                                                     | ⚠ Warning     |
| [CA2214](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2214)  | Do not call overridable methods in constructors                                                                                          | ⚠ Warning     |
| [CA2215](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2215)  | Dispose methods should call base class dispose                                                                                           | ⚠ Warning     |
| [CA2216](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2216)  | Disposable types should declare finalizer                                                                                                | ⚠ Warning     |
| [CA2217](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2217)  | Do not mark enums with FlagsAttribute                                                                                                    | ⛔ Error       |
| [CA2218](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2218)  | Override GetHashCode on overriding Equals                                                                                                | ⚠ Warning     |
| [CA2219](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2219)  | Do not raise exceptions in exception clauses                                                                                             | ⛔ Error       |
| [CA2224](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2224)  | Override Equals on overloading operator equals                                                                                           | 🞅 None         |
| [CA2225](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2225)  | Operator overloads have named alternates                                                                                                 | 🞅 None         |
| [CA2226](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2226)  | Operators should have symmetrical overloads                                                                                              | 🞅 None         |
| [CA2227](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2227)  | Collection properties should be read only                                                                                                | ⚠ Warning     |
| [CA2229](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2229)  | Implement serialization constructors                                                                                                     | 🞅 None         |
| [CA2231](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2231)  | Overload operator equals on overriding ValueType.Equals                                                                                  | ⚠ Warning     |
| [CA2234](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2234)  | Pass _System.Uri_ objects instead of strings                                                                                             | ⚠ Warning     |
| [CA2235](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2235)  | Mark all non-serializable fields                                                                                                         | ⚠ Warning     |
| [CA2237](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2237)  | Mark ISerializable types with SerializableAttribute                                                                                      | ⚠ Warning     |
| [CA2241](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2241)  | Provide correct arguments to formatting methods                                                                                          | ⛔ Error       |
| [CA2242](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2242)  | Test for NaN correctly                                                                                                                   | ⛔ Error       |
| [CA2243](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2243)  | Attribute string literals should parse correctly                                                                                         | ⛔ Error       |
| [CA2244](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2244)  | Do not duplicate indexed element initializations                                                                                         | ⛔ Error       |
| [CA2245](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2245)  | Do not assign a property to itself                                                                                                       | ⛔ Error       |
| [CA2246](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2246)  | Do not assign a symbol and its member in the same statement                                                                              | ⛔ Error       |
| [CA2247](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2247)  | Argument passed to TaskCompletionSource constructor should be                          <br /> TaskCreationOptions enum                   | ⚠ Warning     |
| [CA2248](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2248)  | Provide correct enum argument to Enum.HasFlag                                                                                            | ⛔ Error       |
| [CA2249](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2249)  | Consider using String.Contains instead of String.IndexOf                                                                                 | ⚠ Warning     |
| [CA2250](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2250)  | Use _ThrowIfCancellationRequested_                                                                                                       | ⚠ Warning     |
| [CA2251](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2251)  | Use _String.Equals_ over _String.Compare_                                                                                                | ⚠ Warning     |
| [CA2252](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2252)  | Opt in to preview features before using them                                                                                             | ⛔ Error       |
| [CA2253](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2253)  | Named placeholders should not be numeric values                                                                                          | ⚠ Warning     |
| [CA2254](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2254)  | Template should be a static expression                                                                                                   | ⚠ Warning     |
| [CA2255](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2255)  | The _ModuleInitializer_ attribute should not be used in libraries                                                                        | ⚠ Warning     |
| [CA2256](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2256)  | All members declared in parent interfaces must implement _DICI_-attributed interface                                                     | ⚠ Warning     |
| [CA2257](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2257)  | Members defined on an interface with the _DICIAttribute_ should be _static_                                                              | ⚠ Warning     |
| [CA2258](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2258)  | Providing a _DICI_ interface in Visual Basic is unsupported                                                                              | ⚠ Warning     |
| [CA2259](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2259) | Ensure *ThreadStatic* is only used with static fields                                                                                    | ⚠ Warning     |
| [CA2260](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2260) | Implement generic math interfaces correctly                                                                                              | ⚠ Warning     |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_diagnostic.CA1816.severity = suggestion 
dotnet_diagnostic.CA2200.severity = warning
dotnet_diagnostic.CA2201.severity = warning
dotnet_diagnostic.CA2207.severity = warning 
dotnet_diagnostic.CA2208.severity = warning
dotnet_diagnostic.CA2211.severity = warning
dotnet_diagnostic.CA2213.severity = warning 
dotnet_diagnostic.CA2214.severity = warning 
dotnet_diagnostic.CA2215.severity = warning
dotnet_diagnostic.CA2216.severity = warning 
dotnet_diagnostic.CA2217.severity = error 
dotnet_diagnostic.CA2218.severity = warning
dotnet_diagnostic.CA2219.severity = error
dotnet_diagnostic.CA2224.severity = none
dotnet_diagnostic.CA2225.severity = none
dotnet_diagnostic.CA2226.severity = none
dotnet_diagnostic.CA2227.severity = warning
dotnet_diagnostic.CA2229.severity = none
dotnet_diagnostic.CA2231.severity = warning
dotnet_diagnostic.CA2234.severity = warning 
dotnet_diagnostic.CA2235.severity = warning 
dotnet_diagnostic.CA2237.severity = warning 
dotnet_diagnostic.CA2241.severity = error
dotnet_diagnostic.CA2242.severity = error
dotnet_diagnostic.CA2243.severity = error 
dotnet_diagnostic.CA2244.severity = error
dotnet_diagnostic.CA2245.severity = error
dotnet_diagnostic.CA2246.severity = error
dotnet_diagnostic.CA2247.severity = warning
dotnet_diagnostic.CA2248.severity = error
dotnet_diagnostic.CA2249.severity = warning
dotnet_diagnostic.CA2250.severity = warning
dotnet_diagnostic.CA2251.severity = warning
dotnet_diagnostic.CA2252.severity = error
dotnet_diagnostic.CA2253.severity = warning
dotnet_diagnostic.CA2254.severity = warning
dotnet_diagnostic.CA2255.severity = warning
dotnet_diagnostic.CA2256.severity = warning
dotnet_diagnostic.CA2257.severity = warning
dotnet_diagnostic.CA2258.severity = warning
dotnet_diagnostic.CA2259.severity = warning
dotnet_diagnostic.CA2260.severity = warning
```

</details>

## Code style rules

### Language rules | *this* preferences

### Language rules | Modifier preferences

### Language rules | Parentheses preferences

### Language rules | Expression-level preferences

### Language rules | Namespace declaration preferences

### Language rules | Null-checking preferences

### Language rules | *var* preferences

### Language rules | Expression-bodied preferences

### Language rules | Pattern matching preferences

### Language rules | Code block preferences

### Language rules | *using* preferences

### Language rules | File header preferences

### Language rules | Namespace naming preferences

### Unnecessary code rules

### Miscellanous rules

### Formatting rules

### Naming rules
