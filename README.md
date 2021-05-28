# Usage:

# Example: Replace placeholder from HTML template

```
//HTML string Template
string htmlTemplate =
@"<div>
<h1>{Title}</h1>
<div>
{Content}
</div>
</div>";

//Data
var data = new { Title = "Demo", Content = "Replace html placeholder" };

//call this method to get result
var result = ReplacePlaceHolder.ReplacePlaceholder(data, htmlTemplate)

/* Would render:
<div>
<h1>Demo</h1>
<div>
Replace html placeholder
</div>
</div>
*/
```
# Example: Replace placeholder from JSON template

```
//JSON string Template
string JsonTemplate =
@"{
Title:{Title}
Content: {Content}
}";

//Data
var data = new { Title = "Demo", Content = "Replace JSON placeholder" };

//call this method to get result
var result = ReplacePlaceHolder.ReplacePlaceholder(data, JsonTemplate)

/* Would render:
{
Title:Demo
Content: replace JSON placeholder
}
*/
```




