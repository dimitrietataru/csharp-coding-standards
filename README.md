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

