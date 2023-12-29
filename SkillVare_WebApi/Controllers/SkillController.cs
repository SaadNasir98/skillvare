using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillVare_WebApi.Models;
using SkillVare_WebApi.Responce;
using SkillVare_WebApi.Services;
using System.Net;

namespace SkillVare_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly SkillsServices service;
        private readonly Skillcategory_Service skillcategory_Service;
        private readonly CVService cVService;

        public SkillController(SkillsServices service, Skillcategory_Service skillcategory_Service, CVService cVService)
        {
            this.service = service;
            this.skillcategory_Service = skillcategory_Service;
            this.cVService = cVService;
        }

        //Skill
        [AllowAnonymous]
        [HttpGet]
        [Route("Get_Skill")]
        public async Task<IActionResult> Getskill(int Id)
        {
            try
            {
                var result = await service.getSkill(Id);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = "Category",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Insert_Skill")]
        public async Task<IActionResult> InsertSkill([FromBody] Skills skillCategory)
        {
            try
            {
                var result = await service.insertSkill(skillCategory);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Inserted Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("Update_Skill/{Id}")]
        public async Task<IActionResult> UpdateSkill(int Id, Skills param)
        {
            try
            {
                var result = await service.updateSkill(Id, param);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Updated Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("DeleteSkill/{Id}")]
        public async Task<IActionResult> DeleteItem(int Id)
        {
            try
            {
                var result = await service.deleteSkill(Id);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Delete Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //Skill_Category

        [AllowAnonymous]
        [HttpGet]
        [Route("Get_SkillCateogry")]
        public async Task<IActionResult> GetskillCategory(int Id)
        {
            try
            {
                var result = await skillcategory_Service.getSkillcategory(Id);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = "SkillCateogry",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Insert_SkillCateogry")]
        public async Task<IActionResult> InsertSkillCateogry([FromBody] SkillCategory skillCategory)
        {
            try
            {
                var result = await skillcategory_Service.insertSkillcategory(skillCategory);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Inserted Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("Update_SkillCateogry/{Id}")]
        public async Task<IActionResult> UpdateSkillCateogry(int Id, SkillCategory param)
        {
            try
            {
                var result = await skillcategory_Service.updateSkillcategory(Id, param);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Updated Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("DeleteSkillCateogry/{Id}")]
        public async Task<IActionResult> DeleteSkillCateogry(int Id)
        {
            try
            {
                var result = await skillcategory_Service.deleteSkillcategory(Id);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Delete Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //CV Template

        [AllowAnonymous]
        [HttpGet]
        [Route("Get_CvTemplate")]
        public async Task<IActionResult> GetCvTemplate(int Id)
        {
            try
            {
                var result = await cVService.getCVTemplate(Id);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = "CV_Template",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Insert_CvTemplate")]
        public async Task<IActionResult> InsertCvTemplate([FromBody] CV_Template skillCategory)
        {
            try
            {
                var result = await cVService.insertCVTemplate(skillCategory);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Inserted Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("Update_CvTemplate/{Id}")]
        public async Task<IActionResult> UpdateCvTemplate(int Id, CV_Template param)
        {
            try
            {
                var result = await cVService.updateCVTemplate(Id, param);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Updated Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("DeleteCvTemplate/{Id}")]
        public async Task<IActionResult> DeleteCvTemplate(int Id)
        {
            try
            {
                var result = await cVService.deleteCVTemplate(Id);
                return Ok(new ApiResponse
                {
                    status_code = ((result != null) ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest),
                    Message = result != null ? "Delete Successfully" : "failed! try again",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
