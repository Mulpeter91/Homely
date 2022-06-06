function my_function(message) {
    console.log("from js script " + message);
}

function my_csharp_function() {
    DotNet.invokeMethodAsync("Homely", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript " + result);
        })
}

function csharp_instance_invocation(dotnetHelper) {
    console.log("counter routed through javascript");
    dotnetHelper.invokeMethodAsync("IncrementCountJsInvokable");
}