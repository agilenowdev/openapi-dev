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
 * The record of Config information.
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-07-01T14:05:01.090617400+03:00[Europe/Helsinki]", comments = "Generator version: 7.6.0")
public class ConfigText {
  public static final String SERIALIZED_NAME_ID = "Id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_WEBHOOK_ENTITY_ID = "WebhookEntityId";
  @SerializedName(SERIALIZED_NAME_WEBHOOK_ENTITY_ID)
  private String webhookEntityId;

  public static final String SERIALIZED_NAME_HAS_CREATE_ACCESS = "HasCreateAccess";
  @SerializedName(SERIALIZED_NAME_HAS_CREATE_ACCESS)
  private Boolean hasCreateAccess = false;

  public static final String SERIALIZED_NAME_HAS_UPDATE_ACCESS = "HasUpdateAccess";
  @SerializedName(SERIALIZED_NAME_HAS_UPDATE_ACCESS)
  private Boolean hasUpdateAccess = false;

  public static final String SERIALIZED_NAME_HAS_DELETE_ACCESS = "HasDeleteAccess";
  @SerializedName(SERIALIZED_NAME_HAS_DELETE_ACCESS)
  private Boolean hasDeleteAccess = false;

  public static final String SERIALIZED_NAME_IS_ACTIVE = "Is_Active";
  @SerializedName(SERIALIZED_NAME_IS_ACTIVE)
  private Boolean isActive = false;

  public static final String SERIALIZED_NAME_MODIFIED_BY = "ModifiedBy";
  @SerializedName(SERIALIZED_NAME_MODIFIED_BY)
  private String modifiedBy;

  public static final String SERIALIZED_NAME_MODIFIED_ON = "ModifiedOn";
  @SerializedName(SERIALIZED_NAME_MODIFIED_ON)
  private OffsetDateTime modifiedOn = OffsetDateTime.parse("1900-01-01T01:39:49+01:39:49[Europe/Helsinki]", java.time.format.DateTimeFormatter.ISO_ZONED_DATE_TIME.withZone(java.time.ZoneId.systemDefault()));

  public static final String SERIALIZED_NAME_CREATED_BY = "CreatedBy";
  @SerializedName(SERIALIZED_NAME_CREATED_BY)
  private String createdBy;

  public static final String SERIALIZED_NAME_CREATED_ON = "CreatedOn";
  @SerializedName(SERIALIZED_NAME_CREATED_ON)
  private OffsetDateTime createdOn = OffsetDateTime.parse("1900-01-01T01:39:49+01:39:49[Europe/Helsinki]", java.time.format.DateTimeFormatter.ISO_ZONED_DATE_TIME.withZone(java.time.ZoneId.systemDefault()));

  public ConfigText() {
  }

  public ConfigText id(String id) {
    this.id = id;
    return this;
  }

   /**
   * The identifier of the config
   * @return id
  **/
  @javax.annotation.Nonnull
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }


  public ConfigText webhookEntityId(String webhookEntityId) {
    this.webhookEntityId = webhookEntityId;
    return this;
  }

   /**
   * Identifier of webhook entity.
   * @return webhookEntityId
  **/
  @javax.annotation.Nonnull
  public String getWebhookEntityId() {
    return webhookEntityId;
  }

  public void setWebhookEntityId(String webhookEntityId) {
    this.webhookEntityId = webhookEntityId;
  }


  public ConfigText hasCreateAccess(Boolean hasCreateAccess) {
    this.hasCreateAccess = hasCreateAccess;
    return this;
  }

   /**
   * Service has create access to data
   * @return hasCreateAccess
  **/
  @javax.annotation.Nullable
  public Boolean getHasCreateAccess() {
    return hasCreateAccess;
  }

  public void setHasCreateAccess(Boolean hasCreateAccess) {
    this.hasCreateAccess = hasCreateAccess;
  }


  public ConfigText hasUpdateAccess(Boolean hasUpdateAccess) {
    this.hasUpdateAccess = hasUpdateAccess;
    return this;
  }

   /**
   * Service has update access to data
   * @return hasUpdateAccess
  **/
  @javax.annotation.Nullable
  public Boolean getHasUpdateAccess() {
    return hasUpdateAccess;
  }

  public void setHasUpdateAccess(Boolean hasUpdateAccess) {
    this.hasUpdateAccess = hasUpdateAccess;
  }


  public ConfigText hasDeleteAccess(Boolean hasDeleteAccess) {
    this.hasDeleteAccess = hasDeleteAccess;
    return this;
  }

   /**
   * Service has delete access to data
   * @return hasDeleteAccess
  **/
  @javax.annotation.Nullable
  public Boolean getHasDeleteAccess() {
    return hasDeleteAccess;
  }

  public void setHasDeleteAccess(Boolean hasDeleteAccess) {
    this.hasDeleteAccess = hasDeleteAccess;
  }


  public ConfigText isActive(Boolean isActive) {
    this.isActive = isActive;
    return this;
  }

   /**
   * If true, the configuration is active
   * @return isActive
  **/
  @javax.annotation.Nullable
  public Boolean getIsActive() {
    return isActive;
  }

  public void setIsActive(Boolean isActive) {
    this.isActive = isActive;
  }


  public ConfigText modifiedBy(String modifiedBy) {
    this.modifiedBy = modifiedBy;
    return this;
  }

   /**
   * The Identifier of the user who updated the record
   * @return modifiedBy
  **/
  @javax.annotation.Nullable
  public String getModifiedBy() {
    return modifiedBy;
  }

  public void setModifiedBy(String modifiedBy) {
    this.modifiedBy = modifiedBy;
  }


  public ConfigText modifiedOn(OffsetDateTime modifiedOn) {
    this.modifiedOn = modifiedOn;
    return this;
  }

   /**
   * The date the record was updated.
   * @return modifiedOn
  **/
  @javax.annotation.Nullable
  public OffsetDateTime getModifiedOn() {
    return modifiedOn;
  }

  public void setModifiedOn(OffsetDateTime modifiedOn) {
    this.modifiedOn = modifiedOn;
  }


  public ConfigText createdBy(String createdBy) {
    this.createdBy = createdBy;
    return this;
  }

   /**
   * The Identifier of the user who created the record
   * @return createdBy
  **/
  @javax.annotation.Nullable
  public String getCreatedBy() {
    return createdBy;
  }

  public void setCreatedBy(String createdBy) {
    this.createdBy = createdBy;
  }


  public ConfigText createdOn(OffsetDateTime createdOn) {
    this.createdOn = createdOn;
    return this;
  }

   /**
   * The date the record was created.
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
    ConfigText configText = (ConfigText) o;
    return Objects.equals(this.id, configText.id) &&
        Objects.equals(this.webhookEntityId, configText.webhookEntityId) &&
        Objects.equals(this.hasCreateAccess, configText.hasCreateAccess) &&
        Objects.equals(this.hasUpdateAccess, configText.hasUpdateAccess) &&
        Objects.equals(this.hasDeleteAccess, configText.hasDeleteAccess) &&
        Objects.equals(this.isActive, configText.isActive) &&
        Objects.equals(this.modifiedBy, configText.modifiedBy) &&
        Objects.equals(this.modifiedOn, configText.modifiedOn) &&
        Objects.equals(this.createdBy, configText.createdBy) &&
        Objects.equals(this.createdOn, configText.createdOn);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, webhookEntityId, hasCreateAccess, hasUpdateAccess, hasDeleteAccess, isActive, modifiedBy, modifiedOn, createdBy, createdOn);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConfigText {\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    webhookEntityId: ").append(toIndentedString(webhookEntityId)).append("\n");
    sb.append("    hasCreateAccess: ").append(toIndentedString(hasCreateAccess)).append("\n");
    sb.append("    hasUpdateAccess: ").append(toIndentedString(hasUpdateAccess)).append("\n");
    sb.append("    hasDeleteAccess: ").append(toIndentedString(hasDeleteAccess)).append("\n");
    sb.append("    isActive: ").append(toIndentedString(isActive)).append("\n");
    sb.append("    modifiedBy: ").append(toIndentedString(modifiedBy)).append("\n");
    sb.append("    modifiedOn: ").append(toIndentedString(modifiedOn)).append("\n");
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
    openapiFields.add("WebhookEntityId");
    openapiFields.add("HasCreateAccess");
    openapiFields.add("HasUpdateAccess");
    openapiFields.add("HasDeleteAccess");
    openapiFields.add("Is_Active");
    openapiFields.add("ModifiedBy");
    openapiFields.add("ModifiedOn");
    openapiFields.add("CreatedBy");
    openapiFields.add("CreatedOn");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("Id");
    openapiRequiredFields.add("WebhookEntityId");
  }

 /**
  * Validates the JSON Element and throws an exception if issues found
  *
  * @param jsonElement JSON Element
  * @throws IOException if the JSON Element is invalid with respect to ConfigText
  */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!ConfigText.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in ConfigText is not found in the empty JSON string", ConfigText.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!ConfigText.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `ConfigText` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : ConfigText.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if (!jsonObj.get("Id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `Id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("Id").toString()));
      }
      if (!jsonObj.get("WebhookEntityId").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `WebhookEntityId` to be a primitive type in the JSON string but got `%s`", jsonObj.get("WebhookEntityId").toString()));
      }
      if ((jsonObj.get("ModifiedBy") != null && !jsonObj.get("ModifiedBy").isJsonNull()) && !jsonObj.get("ModifiedBy").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `ModifiedBy` to be a primitive type in the JSON string but got `%s`", jsonObj.get("ModifiedBy").toString()));
      }
      if ((jsonObj.get("CreatedBy") != null && !jsonObj.get("CreatedBy").isJsonNull()) && !jsonObj.get("CreatedBy").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `CreatedBy` to be a primitive type in the JSON string but got `%s`", jsonObj.get("CreatedBy").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!ConfigText.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'ConfigText' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<ConfigText> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(ConfigText.class));

       return (TypeAdapter<T>) new TypeAdapter<ConfigText>() {
           @Override
           public void write(JsonWriter out, ConfigText value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public ConfigText read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of ConfigText given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of ConfigText
  * @throws IOException if the JSON string is invalid with respect to ConfigText
  */
  public static ConfigText fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, ConfigText.class);
  }

 /**
  * Convert an instance of ConfigText to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

