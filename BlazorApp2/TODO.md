# TODO for Fixing ListaProdotti.razor

- [x] Add @key="@product.Id" to the table row in the @foreach loop
- [x] Wrap add/edit inputs in EditForm with DataAnnotationsValidator and ValidationSummary
- [x] Introduce bool isEditing flag to distinguish add/edit modes
- [x] Add "Cancel" button to clear form and reset isEditing
- [x] Modify SaveProduct to reset isEditing after saving
- [x] Add "Add New Product" button to clear form for adding
- [x] Ensure form shows appropriate labels or states
- [x] Test the component for add, edit, delete with validation
- [x] Run the application and verify no errors
