using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.API.Configurations.Model;
using Shop.API.Configurations;
using Shop.Catalog.Domain.Categories;
using Shop.API.Controllers.ParentCategory.Models;
using MediatR;
using Shop.Catalog.Application.Contracts.ParentCategory;
using Shop.Catalog.Domain.Contract;

namespace Shop.API.Controllers.ParentCategory
{
    [Route("ParentCategory")]
    [ApiController]
    public class ParentCategoryController : BaseController
    {
        private readonly IMediator _mediator;

        public ParentCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResult<CreateParentCategoryResponse>>> Create(CreateParentCategoryModel model)
        {
            var parentCategoryCommand = new CreateParentCategoryCommand(model.Name, model.Description, "", false);
            var createParentCategoryResponse = await _mediator.Send(parentCategoryCommand);

            //  await CommandBus.DispatchAsync(command, cancellationToken);

            var response = ApiResult<CreateParentCategoryResponse>.SuccessResult(createParentCategoryResponse, "Parent category created successfully");

            return Ok(response);
        }
        //[HttpGet]
        //public async Task<ActionResult<ApiResult<>>>

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int id, UpdateCategoryCommand command)
        //{
        //    if (id != command.Id)
        //        return new ApiResultActionResult<ResultModel<string>>(
        //            ApiResult<ResultModel<string>>.FailureResult("Invalid category ID."));

        //    await Mediator.Send(command);
        //    return new ApiResultActionResult<ResultModel<string>>(
        //        ApiResult<ResultModel<string>>.SuccessResult(null, "Category updated successfully."));
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    await Mediator.Send(new DeleteCategoryCommand { Id = id });
        //    return new ApiResultActionResult<ResultModel<string>>(
        //        ApiResult<ResultModel<string>>.SuccessResult(null, "Category deleted successfully."));
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var category = await Mediator.Send(new GetCategoryByIdQuery { Id = id });
        //    if (category == null)
        //        return new ApiResultActionResult<ResultModel<Category>>(
        //            ApiResult<ResultModel<Category>>.FailureResult("Category not found."));

        //    return new ApiResultActionResult<ResultModel<Category>>(
        //        ApiResult<ResultModel<Category>>.SuccessResult(new ResultModel<Category> { Data = category }));
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var categories = await Mediator.Send(new GetAllCategoriesQuery());
        //    return new ApiResultActionResult<ResultModel<IEnumerable<Category>>>(
        //        ApiResult<ResultModel<IEnumerable<Category>>>.SuccessResult(
        //            new ResultModel<IEnumerable<Category>> { Data = categories }));
        //}
    }
}
