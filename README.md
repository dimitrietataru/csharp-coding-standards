# csharp-coding-standards
An opinionated C# .editorconfig

## Visual Studio | Code Style

### General | _this._ preferences

| Description                          | Preference           | Severity   |
| :----------------------------------- | :------------------- | :--------: |
| Qualify field access with _this._    | Do not prefer _this_ | ⚠ Warning |
| Qualify property access with _this._ | Do not prefer _this_ | ⚠ Warning |
| Qualify method access with _this._   | Do not prefer _this_ | ⚠ Warning |
| Qualify event access with _this._    | Do not prefer _this_ | ⚠ Warning |

``` EditorConfig
dotnet_style_qualification_for_event = false:warning
dotnet_style_qualification_for_field = false:warning
dotnet_style_qualification_for_method = false:warning
dotnet_style_qualification_for_property = false:warning
```

### General | Predefined type preferences
| Description                         | Preference             | Severity   |
| :---------------------------------- | :--------------------- | :--------: |
| For locals, parameters, and members | Prefer predefined type | ⚠ Warning |
| For member access expressions       | Prefer predefined type | ⚠ Warning |

``` EditorConfig
dotnet_style_predefined_type_for_locals_parameters_members = true:warning
dotnet_style_predefined_type_for_member_access = true:warning
```

