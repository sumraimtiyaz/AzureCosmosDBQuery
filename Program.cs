using AzureCosmosQueries;
using Microsoft.Azure.Cosmos;


class Program
{
    private static readonly string EndpointUrl = "https://localhost:8081/";
    private static readonly string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
    private static CosmosClient cosmosClient;
    private static Database database;
    private static Container container;

    private static readonly string databaseId = "cosmicworks1";
    private static readonly string containerId = "survey";

    static async Task Main(string[] args)
    {

        try
        {
            using (CosmosClient cosmosClient = new CosmosClient(EndpointUrl, PrimaryKey))
            {
                // Create the database if it doesn't exist
                Database database = await cosmosClient.CreateDatabaseIfNotExistsAsync(
                    id: databaseId,
                    throughput: 400
                );
                Console.WriteLine($"Database '{databaseId}' created or retrieved.");

                // Create the container if it doesn't exist
                Container container = await database.CreateContainerIfNotExistsAsync(
                    id: containerId,
                    partitionKeyPath: "/id"
                );
                Console.WriteLine($"Container '{containerId}' created or retrieved.");

                // Add a new item (dummy JSON data) to the container
                SurveyResponse surveyResponse = new SurveyResponse
                {
                    Id = "compliance_supplieronboarding_diversity_0002198215",
                    TenantId = "compliance",
                    ProgramId = "supplierOnboarding",
                    SurveyId = "compliance_supplieronboarding_diversity",
                    SupplierId = "0002198215",
                    RequestDetailId = "",
                    PartitionKey = "compliance_0002198215",
                    ResponderName = "AQUENT LLC",
                    Properties = new Properties()
                    {
                        CountryCode = "us"
                    },
                    Type = "SurveyAnswer",
                    WorkflowProperties = new WorkflowProperties
                    {
                        Survey = new Survey
                        {
                            SmallBusiness = new SmallBusiness
                            {
                                AnniversaryDate = DateTime.Parse("2022-07-18T00:00:00Z")
                            }
                        }
                    },
                    AnswerJson = "{\r\n  \"smallBusinessQuestion\": \"Yes\",\r\n ... }",
                    ResponseProperties = new ResponseProperties
                    {
                        SurveyStatus = new SurveyStatus
                        {
                            Queue = "DiversityManager",
                            State = "Assigned"
                        },
                        AssignedTo = new AssignedTo
                        {
                            Alias = "v-pankkuma"
                        },
                        ResponderStatus = "Restricted",
                        TradeStatusInformation = null,
                        CalculatedResponderStatus = "Active",
                        CertificateFolderName = "0002198215"
                    },
                    AuditDetails = new AuditDetails
                    {
                        CreatedBy = "testsupplieruat1",
                        CreatedOn = DateTime.Parse("7/21/2021 4:20:51 AM"),
                        ModifiedBy = "Orchestrator",
                        ModifiedOn = DateTime.Parse("2024-10-03T07:35:31.5526159Z")
                    },
                    FlattenedAnswerJson = new List<FlattenedAnswerJson>
                    {

                        new FlattenedAnswerJson
                        {
                            CertificateRowId = "47ec36f3-e3a1-4fd2-833d-c5b894d67bf8",
                            CertNodeId = "smallBusinessUploads",
                            IsActive = true,
                            GracePeriod = 90,
                            StatusLastModifiedDate = DateTime.Parse("2024-10-01T12:21:48.1843682Z"),
                            CertificateType = "Alaskan_Native_Corporation_or_Indian_Tribes",
                            Agency = "Test",
                            IssueDate = DateTime.Parse("2024-09-25T00:00:00"),
                            ExpiryDate = DateTime.Parse("2025-10-07T00:00:00"),
                            Status = "Expired_Needs_Attention",
                            LastMailTriggeredStatus = true,
                            LastMailTriggeredDate = DateTime.Parse("2024-09-17T08:00:06.1209545Z"),
                            MailRequestId = "nam-cu01_7001e9fe-da2f-4a12-ab95-e965e268f669",
                            FileUpload = new List<FileUpload>
                            {
                                new FileUpload
                                {
                                    Name = "Cert.txt",
                                    Type = "text/plain",
                                    Content = "1ccdd941-2409-4222-99a6-c1e2699c3a97"
                                }
                            }
                        },
                        new FlattenedAnswerJson
                        {
                            CertificateRowId = "fbb4d6db-f5ab-48ed-93fa-7aa8c3ab6fb3",
                            CertNodeId = "smallBusinessUploads",
                            IsActive = true,
                            GracePeriod = 90,
                            StatusLastModifiedDate = DateTime.Parse("2024-10-01T12:21:48.1844354Z"),
                            CertificateType = "Alaskan_Native_Corporation_or_Indian_Tribes",
                            Agency = null,
                            IssueDate = null,
                            ExpiryDate = null,
                            Status = "Pending_Supplier_Response",
                            LastMailTriggeredStatus = false,
                            LastMailTriggeredDate = null,
                            MailRequestId = null,
                            FileUpload = null
                        },
                        new FlattenedAnswerJson
                        {
                            CertificateRowId = "4144dea1-1472-4484-b3d7-609f6a9f9104",
                            CertNodeId = "minorityUploads",
                            IsActive = true,
                            GracePeriod = 90,
                            StatusLastModifiedDate = DateTime.Parse("2024-10-01T08:00:31.8337389Z"),
                            CertificateType = "National_Minority_Supplier_Development_Council_(NMSDC)",
                            Agency = "ABC Agency",
                            IssueDate = DateTime.Parse("2021-06-01T00:00:00"),
                            ExpiryDate = DateTime.Parse("2024-10-31T00:00:00"),
                            Status = "Expired_Needs_Attention",
                            LastMailTriggeredStatus = true,
                            LastMailTriggeredDate = DateTime.Parse("2023-08-02T17:13:47.3885967Z"),
                            MailRequestId = "0c5a5ee8-498c-4839-96e0-3e9be829a501",
                            FileUpload = new List<FileUpload>
                            {
                                new FileUpload
                                {
                                    Name = "UAT Testing.docx",
                                    Type = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                                    Content = "15d38f49-eb08-447f-ad66-7af4b1b4186f"
                                }
                            }
                        },
                        new FlattenedAnswerJson
                        {
                            CertificateRowId = "6f0db94b-8d1f-417f-ad25-3fd5d0135c2b",
                            CertNodeId = "minorityUploads",
                            IsActive = true,
                            GracePeriod = 90,
                            StatusLastModifiedDate = DateTime.Parse("2024-10-01T12:25:58.8559792Z"),
                            CertificateType = "Federal_Government",
                            Agency = "test",
                            IssueDate = DateTime.Parse("2024-10-01T00:00:00"),
                            ExpiryDate = DateTime.Parse("2025-01-15T00:00:00"),
                            Status = "In_Review",
                            LastMailTriggeredStatus = false,
                            LastMailTriggeredDate = null,
                            MailRequestId = null,
                            FileUpload = new List<FileUpload>
                            {
                                new FileUpload
                                {
                                    Name = "Cert.txt",
                                    Type = "text/plain",
                                    Content = "f698-456c-b16d-0ed7b6ddb1c5"
                                }
                            }
                        },
                        new FlattenedAnswerJson
                        {
                            CertificateRowId = "c278396e-6333-4761-a245-ff820f25fff7",
                            CertNodeId = "womenUploads",
                            IsActive = true,
                            GracePeriod = 90,
                            StatusLastModifiedDate = DateTime.Parse("2024-10-01T06:04:26.2053918Z"),
                            CertificateType = "Federal_Government",
                            Agency = "XYZ Agency",
                            IssueDate = DateTime.Parse("2020-12-01T00:00:00"),
                            ExpiryDate = DateTime.Parse("2024-10-31T00:00:00"),
                            Status = "Expired_Needs_Attention",
                            LastMailTriggeredStatus = true,
                            LastMailTriggeredDate = DateTime.Parse("2022-03-01T08:00:56.9065287Z"),
                            MailRequestId = "d81b5de9-f9cc-4f33-9cbb-0157cc6dd2bb",
                            FileUpload = new List<FileUpload>
                            {
                                new FileUpload
                                {
                                    Name = "UAT Testing 2.docx",
                                    Type = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                                    Content = "beafbe05-840b-4d57-afd1-2f237f952019"
                                }
                            }
                        },
                        new FlattenedAnswerJson
                        {
                            CertificateRowId = "527cbaa2-15a9-4a68-a0ab-3fe7160bd90b",
                            CertNodeId = "womenUploads",
                            IsActive = true,
                            GracePeriod = 90,
                            StatusLastModifiedDate = DateTime.Parse("2024-10-03T07:35:31.5525478Z"),
                            CertificateType = "Women's_Business_Enterprise_National_Council_(WBENC)",
                            Agency = "test",
                            IssueDate = DateTime.Parse("2024-09-12T00:00:00"),
                            ExpiryDate = DateTime.Parse("2025-10-01T00:00:00"),
                            Status = "Approved",
                            LastMailTriggeredStatus = false,
                            LastMailTriggeredDate = null,
                            MailRequestId = null,
                            FileUpload = new List<FileUpload>
                            {
                                new FileUpload
                                {
                                    Name = "Web - Copy.txt",
                                    Type = "text/plain",
                                    Content = "6171-4c7a-ae86-afe3358da1bf"
                                }
                            }
                        },
                        new FlattenedAnswerJson
                        {
                            CertificateRowId = "0d4b6a96-56de-4da7-8e64-e324eeb4ae16",
                            CertNodeId = "womenUploads",
                            IsActive = true,
                            GracePeriod = 90,
                            StatusLastModifiedDate = DateTime.Parse("2024-09-25T04:49:10.9473844Z"),
                            CertificateType = "State_Local_County_Agency",
                            Agency = null,
                            IssueDate = null,
                            ExpiryDate = null,
                            Status = "Pending_Supplier_Response",
                            LastMailTriggeredStatus = false,
                            LastMailTriggeredDate = null,
                            MailRequestId = null,
                            FileUpload = null
                        }

                    }
                };

                // Use UpsertItemAsync to add or update the item
                await container.UpsertItemAsync(surveyResponse);
                Console.WriteLine("Item inserted successfully!");

                string sqlQueryText = @"
                    SELECT c.partitionKey, c.supplierId, c.id, c.requestDetailId 
                    FROM c 
                    WHERE EXISTS (
                        SELECT VALUE n 
                        FROM n IN c.flattenedAnswerJson 
                        WHERE 
                            n.certNodeId = 'minorityUploads'
                            AND n.isActive = true
                            AND n.status = 'Expired_Needs_Attention'
                            AND n.expiryDate >= '2024-10-31'
                            AND n.expiryDate < '2024-11-01'
                            AND (n.lastMailTriggeredDate = null OR n.lastMailTriggeredDate < '2024-10-01')
                            AND NOT EXISTS (
                                SELECT VALUE n2
                                FROM n2 IN c.flattenedAnswerJson
                                WHERE n2.certNodeId = n.certNodeId
                                AND n2.status <> 'Expired_Needs_Attention'
                            )
                    )";


                ////Old Query
                //string sqlQueryText = @"
                //    SELECT c.partitionKey, c.supplierId, c.id, c.requestDetailId 
                //    FROM c 
                //    WHERE EXISTS( 
                //        SELECT VALUE n 
                //        FROM n IN c.flattenedAnswerJson 
                //        WHERE 
                //            n.certNodeId = 'minorityUploads'
                //            AND n.status = 'Expired_Needs_Attention' 
                //            AND n.expiryDate >= '2024-10-31' 
                //            AND n.expiryDate < '2024-11-01' 
                //            AND (n.lastMailTriggeredDate = null OR n.lastMailTriggeredDate < '2024-10-01') 
                //            AND n.isActive = true 
                //    )";

                QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
                FeedIterator<dynamic> queryResultSetIterator = container.GetItemQueryIterator<dynamic>(queryDefinition);

                Console.WriteLine("Querying item...");
                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<dynamic> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (var result in currentResultSet)
                    {
                        Console.WriteLine($"Item found: {result}");
                    }
                }
            }

        }
        catch (CosmosException ex)
        {
            Console.WriteLine($"Cosmos DB error: {ex.StatusCode}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General error: {ex.Message}");
        }

    }

}
