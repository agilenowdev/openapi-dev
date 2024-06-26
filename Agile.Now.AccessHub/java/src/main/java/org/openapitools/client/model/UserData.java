/*
 * Agile.Now.AccessHub API documentation
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.time.OffsetDateTime;
import java.util.Arrays;
import org.openapitools.client.model.FieldType;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.TypeAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

import org.openapitools.client.JSON;

/**
 * The record of User information.
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-07-01T14:05:01.090617400+03:00[Europe/Helsinki]", comments = "Generator version: 7.6.0")
public class UserData {
  public static final String SERIALIZED_NAME_ID = "Id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_USER_ID = "UserId";
  @SerializedName(SERIALIZED_NAME_USER_ID)
  private FieldType userId;

  public static final String SERIALIZED_NAME_MODIFIED_ON = "ModifiedOn";
  @SerializedName(SERIALIZED_NAME_MODIFIED_ON)
  private OffsetDateTime modifiedOn = OffsetDateTime.parse("1900-01-01T01:39:49+01:39:49[Europe/Helsinki]", java.time.format.DateTimeFormatter.ISO_ZONED_DATE_TIME.withZone(java.time.ZoneId.systemDefault()));

  public static final String SERIALIZED_NAME_MODIFIED_BY = "ModifiedBy";
  @SerializedName(SERIALIZED_NAME_MODIFIED_BY)
  private FieldType modifiedBy;

  public static final String SERIALIZED_NAME_CREATED_BY = "CreatedBy";
  @SerializedName(SERIALIZED_NAME_CREATED_BY)
  private FieldType createdBy;

  public static final String SERIALIZED_NAME_CREATED_ON = "CreatedOn";
  @SerializedName(SERIALIZED_NAME_CREATED_ON)
  private OffsetDateTime createdOn = OffsetDateTime.parse("1900-01-01T01:39:49+01:39:49[Europe/Helsinki]", java.time.format.DateTimeFormatter.ISO_ZONED_DATE_TIME.withZone(java.time.ZoneId.systemDefault()));

  public UserData() {
  }

  public UserData id(String id) {
    this.id = id;
    return this;
  }

   /**
   * The identifier of user department
   * @return id
  **/
  @javax.annotation.Nonnull
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }


  public UserData userId(FieldType userId) {
    this.userId = userId;
    return this;
  }

   /**
   * Get userId
   * @return userId
  **/
  @javax.annotation.Nullable
  public FieldType getUserId() {
    return userId;
  }

  public void setUserId(FieldType userId) {
    this.userId = userId;
  }


  public UserData modifiedOn(OffsetDateTime modifiedOn) {
    this.modifiedOn = modifiedOn;
    return this;
  }

   /**
   * The date the record was updated
   * @return modifiedOn
  **/
  @javax.annotation.Nullable
  public OffsetDateTime getModifiedOn() {
    return modifiedOn;
  }

  public void setModifiedOn(OffsetDateTime modifiedOn) {
    this.modifiedOn = modifiedOn;
  }


  public UserData modifiedBy(FieldType modifiedBy) {
    this.modifiedBy = modifiedBy;
    return this;
  }

   /**
   * Get modifiedBy
   * @return modifiedBy
  **/
  @javax.annotation.Nullable
  public FieldType getModifiedBy() {
    return modifiedBy;
  }

  public void setModifiedBy(FieldType modifiedBy) {
    this.modifiedBy = modifiedBy;
  }


  public UserData createdBy(FieldType createdBy) {
    this.createdBy = createdBy;
    return this;
  }

   /**
   * Get createdBy
   * @return createdBy
  **/
  @javax.annotation.Nullable
  public FieldType getCreatedBy() {
    return createdBy;
  }

  public void setCreatedBy(FieldType createdBy) {
    this.createdBy = createdBy;
  }


  public UserData createdOn(OffsetDateTime createdOn) {
    this.createdOn = createdOn;
    return this;
  }

   /**
   * The date the record was created
   * @return createdOn
  **/
  @javax.annotation.Nullable
  public OffsetDateTime getCreatedOn() {
    return createdOn;
  }

  public void setCreatedOn(OffsetDateTime createdOn) {
    this.createdOn = createdOn;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserData userData = (UserData) o;
    return Objects.equals(this.id, userData.id) &&
        Objects.equals(this.userId, userData.userId) &&
        Objects.equals(this.modifiedOn, userData.modifiedOn) &&
        Objects.equals(this.modifiedBy, userData.modifiedBy) &&
        Objects.equals(this.createdBy, userData.createdBy) &&
        Objects.equals(this.createdOn, userData.createdOn);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, userId, modifiedOn, modifiedBy, createdBy, createdOn);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserData {\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    modifiedOn: ").append(toIndentedString(modifiedOn)).append("\n");
    sb.append("    modifiedBy: ").append(toIndentedString(modifiedBy)).append("\n");
    sb.append("    createdBy: ").append(toIndentedString(createdBy)).append("\n");
    sb.append("    createdOn: ").append(toIndentedString(createdOn)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("Id");
    openapiFields.add("UserId");
    openapiFields.add("ModifiedOn");
    openapiFields.add("ModifiedBy");
    openapiFields.add("CreatedBy");
    openapiFields.add("CreatedOn");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("Id");
  }

 /**
  * Validates the JSON Element and throws an exception if issues found
  *
  * @param jsonElement JSON Element
  * @throws IOException if the JSON Element is invalid with respect to UserData
  */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!UserData.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in UserData is not found in the empty JSON string", UserData.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!UserData.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `UserData` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : UserData.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if (!jsonObj.get("Id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `Id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("Id").toString()));
      }
      // validate the optional field `UserId`
      if (jsonObj.get("UserId") != null && !jsonObj.get("UserId").isJsonNull()) {
        FieldType.validateJsonElement(jsonObj.get("UserId"));
      }
      // validate the optional field `ModifiedBy`
      if (jsonObj.get("ModifiedBy") != null && !jsonObj.get("ModifiedBy").isJsonNull()) {
        FieldType.validateJsonElement(jsonObj.get("ModifiedBy"));
      }
      // validate the optional field `CreatedBy`
      if (jsonObj.get("CreatedBy") != null && !jsonObj.get("CreatedBy").isJsonNull()) {
        FieldType.validateJsonElement(jsonObj.get("CreatedBy"));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!UserData.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'UserData' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<UserData> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(UserData.class));

       return (TypeAdapter<T>) new TypeAdapter<UserData>() {
           @Override
           public void write(JsonWriter out, UserData value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public UserData read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of UserData given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of UserData
  * @throws IOException if the JSON string is invalid with respect to UserData
  */
  public static UserData fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, UserData.class);
  }

 /**
  * Convert an instance of UserData to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

