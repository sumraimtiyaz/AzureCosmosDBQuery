using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCosmosQueries
{
    public class SurveyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("programId")]
        public string ProgramId { get; set; }

        [JsonProperty("surveyId")]
        public string SurveyId { get; set; }

        [JsonProperty("supplierId")]
        public string SupplierId { get; set; }

        [JsonProperty("requestDetailId")]
        public string RequestDetailId { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("responderName")]
        public string ResponderName { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workflowProperties")]
        public WorkflowProperties WorkflowProperties { get; set; }

        [JsonProperty("answerJson")]
        public string AnswerJson { get; set; }

        [JsonProperty("responseProperties")]
        public ResponseProperties ResponseProperties { get; set; }

        [JsonProperty("auditDetails")]
        public AuditDetails AuditDetails { get; set; }

        [JsonProperty("flattenedAnswerJson")]
        public List<FlattenedAnswerJson> FlattenedAnswerJson { get; set; }
    }

    public class Properties
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class WorkflowProperties
    {
        [JsonProperty("survey")]
        public Survey Survey { get; set; }
    }

    public class Survey
    {
        [JsonProperty("smallBusiness")]
        public SmallBusiness SmallBusiness { get; set; }
    }

    public class SmallBusiness
    {
        [JsonProperty("anniversaryDate")]
        public DateTime AnniversaryDate { get; set; }
    }

    public class ResponseProperties
    {
        [JsonProperty("surveyStatus")]
        public SurveyStatus SurveyStatus { get; set; }

        [JsonProperty("assignedTo")]
        public AssignedTo AssignedTo { get; set; }

        [JsonProperty("responderStatus")]
        public string ResponderStatus { get; set; }

        [JsonProperty("tradeStatusInformation")]
        public string TradeStatusInformation { get; set; }

        [JsonProperty("calculatedResponderStatus")]
        public string CalculatedResponderStatus { get; set; }

        [JsonProperty("certificateFolderName")]
        public string CertificateFolderName { get; set; }
    }

    public class SurveyStatus
    {
        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class AssignedTo
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    public class AuditDetails
    {
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedOn")]
        public DateTime ModifiedOn { get; set; }
    }

    public class FlattenedAnswerJson
    {
        [JsonProperty("certificateRowId")]
        public string CertificateRowId { get; set; }

        [JsonProperty("certNodeId")]
        public string CertNodeId { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("gracePeriod")]
        public int GracePeriod { get; set; }

        [JsonProperty("statusLastModifiedDate")]
        public DateTime StatusLastModifiedDate { get; set; }

        [JsonProperty("certificateType")]
        public string CertificateType { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("issueDate")]
        public DateTime? IssueDate { get; set; }

        [JsonProperty("expiryDate")]
        public DateTime? ExpiryDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("lastMailTriggeredStatus")]
        public bool LastMailTriggeredStatus { get; set; }

        [JsonProperty("lastMailTriggeredDate")]
        public DateTime? LastMailTriggeredDate { get; set; }

        [JsonProperty("mailRequestId")]
        public string MailRequestId { get; set; }

        [JsonProperty("fileUpload")]
        public List<FileUpload> FileUpload { get; set; }
    }

    public class FileUpload
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

}
