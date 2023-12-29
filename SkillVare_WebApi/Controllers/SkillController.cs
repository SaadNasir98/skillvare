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
        private readonly UserResume_Service userResume_Service;
        private readonly UserResume_PageService userResume_PageService;
        private readonly UserSkill_Service userSkill_Service;
        public SkillController(SkillsServices service, Skillcategory_Service skillcategory_Service, CVService cVService, UserResume_Service userResume_Service, UserResume_PageService userResume_PageService, UserSkill_Service userSkill_Service)
        {
            this.service = service;
            this.skillcategory_Service = skillcategory_Service;
            this.cVService = cVService;
            this.userResume_Service = userResume_Service;
            this.userResume_PageService = userResume_PageService;
            this.userSkill_Service = userSkill_Service;
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
        public async Task<IActionResult> UpdateSkill(int Id, [FromBody] Skills param)
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
        public async Task<IActionResult> UpdateSkillCateogry(int Id, [FromBody] SkillCategory param)
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
        public async Task<IActionResult> InsertCvTemplate([FromBody] CVTemplate skillCategory)
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
        public async Task<IActionResult> UpdateCvTemplate(int Id, [FromBody] CVTemplate param)
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

        //UserResume

        [AllowAnonymous]
        [HttpGet]
        [Route("Get_UserResume")]
        public async Task<IActionResult> GetUserResume(int Id)
        {
            try
            {
                var result = await userResume_Service.getUserResume(Id);
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
        [Route("Insert_UserResume")]
        public async Task<IActionResult> InsertUserResume([FromBody] User_Resume skillCategory)
        {
            try
            {
                var result = await userResume_Service.insertUserResume(skillCategory);
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
        [Route("Update_UserResume/{Id}")]
        public async Task<IActionResult> UpdateCvTemplate(int Id, [FromBody] User_Resume param)
        {
            try
            {
                var result = await userResume_Service.updateUserResume(Id, param);
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
        [Route("Delete_UserResume/{Id}")]
        public async Task<IActionResult> DeleteUserResume(int Id)
        {
            try
            {
                var result = await userResume_Service.deleteUserResume(Id);
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


        //UserResume_Page

        [AllowAnonymous]
        [HttpGet]
        [Route("Get_UserResume_Page")]
        public async Task<IActionResult> GetUserResume_Page(int Id)
        {
            try
            {
                var result = await userResume_PageService.getUserResume_Page(Id);
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
        [Route("Insert_UserResume_Page")]
        public async Task<IActionResult> InsertUserResume_Page([FromBody] User_Resume_Page skillCategory)
        {
            try
            {
                var result = await userResume_PageService.insertUserResume_Page(skillCategory);
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
        [Route("Update_UserResume_Page/{Id}")]
        public async Task<IActionResult> UpdateUserResume_Page(int Id, [FromBody] User_Resume_Page param)
        {
            try
            {
                var result = await userResume_PageService.updateUserResume_Page(Id, param);
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
        [Route("Delete_UserResume_Page/{Id}")]
        public async Task<IActionResult> DeleteUserResume_Page(int Id)
        {
            try
            {
                var result = await userResume_PageService.deleteUserResume_Page(Id);
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


        //UserSkill

        [AllowAnonymous]
        [HttpGet]
        [Route("Get_UserSkill")]
        public async Task<IActionResult> GetUserSkill(int Id)
        {
            try
            {
                var result = await userSkill_Service.getUserSkill(Id);
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
        [Route("Insert_UserSkill")]
        public async Task<IActionResult> InsertUserSkill([FromBody] User_Skills skillCategory)
        {
            try
            {
                var result = await userSkill_Service.insertUserSkill(skillCategory);
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
        [Route("Update_UserSkill/{Id}")]
        public async Task<IActionResult> UpdateUserSkill(int Id, [FromBody] User_Skills param)
        {
            try
            {
                var result = await userSkill_Service.updateUserSkill(Id, param);
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
        [Route("Delete_UserSkill/{Id}")]
        public async Task<IActionResult> DeleteUserSkill(int Id)
        {
            try
            {
                var result = await userSkill_Service.deleteUserSkill(Id);
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
