# csharp-coding-standards
An opinionated C# .editorconfig

## Visual Studio options

### Code Style | General | _this._ preferences

| Description                          | Preference           | Severity   |
| :----------------------------------- | :------------------- | :--------: |
| Qualify field access with _this._    | Do not prefer _this_ | ⚠ Warning |
| Qualify property access with _this._ | Do not prefer _this_ | ⚠ Warning |
| Qualify method access with _this._   | Do not prefer _this_ | ⚠ Warning |
| Qualify event access with _this._    | Do not prefer _this_ | ⚠ Warning |

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
| Description                         | Preference             | Severity   |
| :---------------------------------- | :--------------------- | :--------: |
| For locals, parameters, and members | Prefer predefined type | ⚠ Warning |
| For member access expressions       | Prefer predefined type | ⚠ Warning |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
dotnet_style_predefined_type_for_locals_parameters_members = true:warning
dotnet_style_predefined_type_for_member_access = true:warning
```

</details>

### Code Style | General | _var_ preferences
| Description                    | Preference           | Severity     |
| :----------------------------- | :------------------- | :----------: |
| For built-in types             | Prefer explicit type | 🛈 Suggestion |
| When variable type is apparent | Prefer _var_         | 🛈 Suggestion |
| Elsewhere                      | Prefer _var_         | 🛈 Suggestion |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_var_elsewhere = true:suggestion
csharp_style_var_for_built_in_types = false:suggestion
csharp_style_var_when_type_is_apparent = true:suggestion
```

</details>

### Code Style | General | Code block preferences
| Description                               | Preference | Severity      |
| :---------------------------------------- | :--------- | :-----------: |
| Prefer braces                             | Yes        | ⚠ Warning    |
| Prefer auto properties                    | Yes        | 🞅 Refactoring |
| Prefer simple _using_ statement           | Yes        | 🛈 Suggestion  |
| Prefer _System.HashCode_ in 'GetHashCode' | Yes        | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_prefer_braces = true:warning
csharp_prefer_simple_using_statement = true:suggestion
dotnet_style_prefer_auto_properties = true:silent
```

</details>

### Code Style | General | Parentheses preferences
| Description                                                    | Preference           | Severity      |
| :------------------------------------------------------------- | :------------------- | :-----------: |
| In arithmetic operators: _*_ _/_ _%_ _+_ _-_ _<<_ _>>_ _&_ _^_ | Always for clarity   | 🛈 Suggestion  |
| In other binary operators: _&&_ _??_ _and_ _or_                | Always for clarity   | 🛈 Suggestion  |
| In relational operators: _<_ _>_ _<=_ _>=_ _is_ _as_ _==_ _!=_ | Always for clarity   | 🛈 Suggestion  |
| In other operators                                             | Never if unnecessary | ⚠ Warning    |

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
| Description                                              | Preference | Severity      |
| :------------------------------------------------------- | :--------- | :-----------: |
| Prefer object initializer                                | Yes        | 🛈 Suggestion  |
| Prefer collection initializer                            | Yes        | 🛈 Suggestion  |
| Prefer simplified boolean expressions                    | Yes        | ⚠ Warning    |
| Prefer switch expression                                 | Yes        | 🛈 Suggestion  |
| Prefer conditional expression over _if_ with assignments | Yes        | 🞅 Refactoring |
| Prefer conditional expression over _if_ with returns     | No         | 🞅 Refactoring |
| Prefer explicit tuple name                               | Yes        | 🛈 Suggestion  |
| Prefer simple 'default' expression                       | Yes        | ⚠ Warning    |
| Prefer inferred tuple element names                      | No         | 🛈 Suggestion  |
| Prefer inferred anonymous type member names              | Yes        | 🞅 Refactoring |
| Prefer local function over anonymous function            | Yes        | ⚠ Warning    |
| Prefer compound assignments                              | Yes        | ⚠ Warning    |
| Prefer implicit object creation when type is aparent     | Yes        | 🛈 Suggestion  |
| Prefer index operator                                    | Yes        | 🛈 Suggestion  |
| Prefer range operator                                    | Yes        | 🛈 Suggestion  |
| Avoid unused value assignments                           | Discard    | 🛈 Suggestion  |
| Avoid expression statements that implicitly ignore value | Discard    | 🛈 Suggestion  |
| Use expression body for methods                          | Never      | 🞅 Refactoring |

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
csharp_style_unused_value_assignment_preference = discard_variable:suggestion
csharp_style_unused_value_expression_statement_preference = discard_variable:suggestion
```

</details>

### Code Style | General | Expression-bodied members
| Description                             | Preference    | Severity      |
| :-------------------------------------- | :-------------| :-----------: |
| Use expression body for methods         | Never         | 🞅 Refactoring |
| Use expression body for constructors    | Never         | 🞅 Refactoring |
| Use expression body for operators       | Never         | 🞅 Refactoring |
| Use expression body for properties      | When possible | 🛈 Suggestion  |
| Use expression body for indexers        | When possible | 🛈 Suggestion  |
| Use expression body for accessors       | When possible | 🛈 Suggestion  |
| Use expression body for lambdas         | Never         | 🛈 Suggestion  |
| Use expression body for local functions | Never         | 🛈 Suggestion  |

<details>
  <summary> .editorconfig </summary>

``` EditorConfig
csharp_style_expression_bodied_methods = false:silent
csharp_style_expression_bodied_constructors = false:silent
csharp_style_expression_bodied_operators = false:silent
csharp_style_expression_bodied_properties = true:suggestion
csharp_style_expression_bodied_indexers = true:suggestion
csharp_style_expression_bodied_accessors = true:suggestion
csharp_style_expression_bodied_lambdas = false:suggestion
csharp_style_expression_bodied_local_functions = false:suggestion
```

</details>
