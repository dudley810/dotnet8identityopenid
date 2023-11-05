AZURE AD DOTNET 8 RC2 ISSUE

SEEMS TO HAPPEN ON LOGOUT and an issue with state

https://localhost:7179/authentication/logout-callback?state=

it can happen with login when you use the (in the client program.cs)

//options.ProviderOptions.LoginMode = "redirect"; login callback is not working

BEFORE RUNNING THE SAMPLE CHANGE

1. **SERVER**

"AzureAd": {
    "Instance": "https://login.microsoftonline.com/",
    "Domain": "DOMAIN",
    "TenantId": "TENANTID",
    "ClientId": "SERVERCLIENTID",
    "CallbackPath": "/signin-oidc",
    "Scopes": "access_as_user"
  },

**2. CLIENT  - appsettings.development.json**

"AzureAd": {
    "Authority": "https://login.microsoftonline.com/TENANTID",
    "ClientId": "clientid",
    "ValidateAuthority": true
  },

**3. CLIENT programs.cs default access token scopes**

api://DOMAIN/APICLIENT/access_as_user


# An unhandled exception occurred while processing the request.

InvalidOperationException: Cannot provide a value for property 'AuthenticationService' on type 'Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView'. There is no registered service of type 'Microsoft.AspNetCore.Components.WebAssembly.Authentication.IRemoteAuthenticationService`1[Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticationState]'.

Microsoft.AspNetCore.Components.ComponentFactory+<>c__DisplayClass9_0.`<CreatePropertyInjector>`g__Initialize|1(IServiceProvider serviceProvider, IComponent component)


InvalidOperationException: Cannot provide a value for property 'AuthenticationService' on type 'Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView'. There is no registered service of type 'Microsoft.AspNetCore.Components.WebAssembly.Authentication.IRemoteAuthenticationService`1[Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticationState]'.
Microsoft.AspNetCore.Components.ComponentFactory+<>c__DisplayClass9_0.`<CreatePropertyInjector>`g__Initialize|1(IServiceProvider serviceProvider, IComponent component)
Microsoft.AspNetCore.Components.ComponentFactory.InstantiateComponent(IServiceProvider serviceProvider, Type componentType, IComponentRenderMode callerSpecifiedRenderMode, Nullable`<int>` parentComponentId)
Microsoft.AspNetCore.Components.RenderTree.Renderer.InstantiateChildComponentOnFrame(RenderTreeFrame[] frames, int frameIndex, int parentComponentId)
Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InitializeNewComponentFrame(ref DiffContext diffContext, int frameIndex)
Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InitializeNewSubtree(ref DiffContext diffContext, int frameIndex)
Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InsertNewFrame(ref DiffContext diffContext, int newFrameIndex)
Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.AppendDiffEntriesForRange(ref DiffContext diffContext, int oldStartIndex, int oldEndIndexExcl, int newStartIndex, int newEndIndexExcl)
Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.ComputeDiff(Renderer renderer, RenderBatchBuilder batchBuilder, int componentId, ArrayRange`<RenderTreeFrame>` oldTree, ArrayRange`<RenderTreeFrame>` newTree)
Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment, out Exception renderFragmentException)
Microsoft.AspNetCore.Components.RenderTree.Renderer.ProcessRenderQueue()
Microsoft.AspNetCore.Components.RenderTree.Renderer.ProcessRenderQueue()
Microsoft.AspNetCore.Components.RenderTree.Renderer.AddToRenderQueue(int componentId, RenderFragment renderFragment)
Microsoft.AspNetCore.Components.ComponentBase.StateHasChanged()
Microsoft.AspNetCore.Components.ComponentBase.CallOnParametersSetAsync()
Microsoft.AspNetCore.Components.ComponentBase.RunInitAndSetParametersAsync()
Microsoft.AspNetCore.Components.Rendering.ComponentState.SetDirectParameters(ParameterView parameters)
Microsoft.AspNetCore.Components.RenderTree.Renderer.RenderRootComponentAsync(int componentId, ParameterView initialParameters)
Microsoft.AspNetCore.Components.HtmlRendering.Infrastructure.StaticHtmlRenderer.BeginRenderingComponent(IComponent component, ParameterView initialParameters)
Microsoft.AspNetCore.Components.Endpoints.EndpointHtmlRenderer.RenderEndpointComponent(HttpContext httpContext, Type rootComponentType, ParameterView parameters, bool waitForQuiescence)
System.Threading.Tasks.ValueTask`<TResult>`.get_Result()
Microsoft.AspNetCore.Components.Endpoints.RazorComponentEndpointInvoker.RenderComponentCore(HttpContext context)
Microsoft.AspNetCore.Components.Endpoints.RazorComponentEndpointInvoker.RenderComponentCore(HttpContext context)
Microsoft.AspNetCore.Components.Rendering.RendererSynchronizationContext+<>c+<`<InvokeAsync>`b__10_0>d.MoveNext()
Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddlewareImpl.Invoke(HttpContext context)

System.InvalidOperationException: Cannot provide a value for property 'AuthenticationService' on type 'Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView'. There is no registered service of type 'Microsoft.AspNetCore.Components.WebAssembly.Authentication.IRemoteAuthenticationService `1[Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticationState]'.    at Microsoft.AspNetCore.Components.ComponentFactory.<>c__DisplayClass9_0.<CreatePropertyInjector>g__Initialize|1(IServiceProvider serviceProvider, IComponent component)    at Microsoft.AspNetCore.Components.ComponentFactory.InstantiateComponent(IServiceProvider serviceProvider, Type componentType, IComponentRenderMode callerSpecifiedRenderMode, Nullable`1 parentComponentId)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.InstantiateChildComponentOnFrame(RenderTreeFrame[] frames, Int32 frameIndex, Int32 parentComponentId)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InitializeNewComponentFrame(DiffContext& diffContext, Int32 frameIndex)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InitializeNewSubtree(DiffContext& diffContext, Int32 frameIndex)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.InsertNewFrame(DiffContext& diffContext, Int32 newFrameIndex)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.AppendDiffEntriesForRange(DiffContext& diffContext, Int32 oldStartIndex, Int32 oldEndIndexExcl, Int32 newStartIndex, Int32 newEndIndexExcl)
   at Microsoft.AspNetCore.Components.RenderTree.RenderTreeDiffBuilder.ComputeDiff(Renderer renderer, RenderBatchBuilder batchBuilder, Int32 componentId, ArrayRange `1 oldTree, ArrayRange`1 newTree)
   at Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment, Exception& renderFragmentException)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.ProcessRenderQueue()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.ProcessRenderQueue()
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.AddToRenderQueue(Int32 componentId, RenderFragment renderFragment)
   at Microsoft.AspNetCore.Components.ComponentBase.StateHasChanged()
   at Microsoft.AspNetCore.Components.ComponentBase.CallOnParametersSetAsync()
   at Microsoft.AspNetCore.Components.ComponentBase.RunInitAndSetParametersAsync()
   at Microsoft.AspNetCore.Components.Rendering.ComponentState.SetDirectParameters(ParameterView parameters)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.RenderRootComponentAsync(Int32 componentId, ParameterView initialParameters)
   at Microsoft.AspNetCore.Components.HtmlRendering.Infrastructure.StaticHtmlRenderer.BeginRenderingComponent(IComponent component, ParameterView initialParameters)
   at Microsoft.AspNetCore.Components.Endpoints.EndpointHtmlRenderer.RenderEndpointComponent(HttpContext httpContext, Type rootComponentType, ParameterView parameters, Boolean waitForQuiescence)
   at Microsoft.AspNetCore.Components.Endpoints.RazorComponentEndpointInvoker.RenderComponentCore(HttpContext context)
   at Microsoft.AspNetCore.Components.Endpoints.RazorComponentEndpointInvoker.RenderComponentCore(HttpContext context)
   at Microsoft.AspNetCore.Components.Rendering.RendererSynchronizationContext.<>c.<`<InvokeAsync>`b__10_0>d.MoveNext()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddlewareImpl.Invoke(HttpContext context)
