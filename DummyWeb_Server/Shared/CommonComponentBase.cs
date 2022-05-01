using Dummy_Repository.Repository.IRepository;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DummyWeb_Server.Shared;

public class CommonComponentBase: ComponentBase
{
    /// <summary>
    /// Gets or sets the repository.
    /// </summary>
    /// <value>
    /// The repository.
    /// </value>
    [Inject]
    public IDummyRepository Repository { get; set; }

    /// <summary>
    /// Gets or sets the js runtime.
    /// </summary>
    /// <value>
    /// The js runtime.
    /// </value>
    [Inject]
    public IJSRuntime _JsRuntime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is visible modal spinner.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is visible modal spinner; otherwise, <c>false</c>.
    /// </value>
    public bool IsVisibleModalSpinner { get; set; } = false;
    /// <summary>
    /// Gets or sets a value indicating whether this instance is visible modal create.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is visible modal create; otherwise, <c>false</c>.
    /// </value>
    public bool IsVisibleModalCreate { get; set; } = false;
    /// <summary>
    /// Gets or sets a value indicating whether this instance is visible modal edit.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is visible modal edit; otherwise, <c>false</c>.
    /// </value>
    public bool IsVisibleModalEdit { get; set; } = false;
    /// <summary>
    /// Gets or sets a value indicating whether this instance is visible modal delete.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is visible modal delete; otherwise, <c>false</c>.
    /// </value>
    public bool IsVisibleModalDelete { get; set; } = false;

    /// <summary>
    /// Sweets the alert success.
    /// </summary>
    protected async Task SweetAlertSuccess()
    {
        await _JsRuntime.InvokeVoidAsync("ShowSwal", "success", "Berhasil");
    }

    /// <summary>
    /// Sweets the alert failure.
    /// </summary>
    protected async Task SweetAlertFailure(string message)
    {
        await _JsRuntime.InvokeVoidAsync("ShowSwal", "error", message);
    }

    /// <summary>
    /// Sweets the alert warning.
    /// </summary>
    /// <param name="message">The message.</param>
    protected async Task SweetAlertWarning(string message)
    {
        await _JsRuntime.InvokeVoidAsync("ShowSwal", "warning", message);
    }

    /// <summary>
    /// Closes this instance.
    /// </summary>
    protected void Close()
    {
        IsVisibleModalCreate = false;
        IsVisibleModalEdit = false;
        IsVisibleModalDelete = false;
        StateHasChanged();
    }
}

