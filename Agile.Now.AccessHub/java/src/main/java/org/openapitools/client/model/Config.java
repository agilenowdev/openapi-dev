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
import org.openapitools.client.model.AbstractLong;
import org.openapitools.client.model.AbstractText;

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
public class Config {
  public static final String SERIALIZED_NAME_ID = "Id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_WEBHOOK_ENTITY_ID = "WebhookEntityId";
  @SerializedName(SERIALIZED_NAME_WEBHOOK_ENTITY_ID)
  private AbstractText webhookEntityId;

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
  private AbstractLong modifiedBy;

  public static final String SERIALIZED_NAME_MODIFIED_ON = "ModifiedOn";
  @SerializedName(SERIALIZED_NAME_MODIFIED_ON)
  private OffsetDateTime modifiedOn = OffsetDateTime.parse("1900-01-01T01:39:49+01:39:49[Europe/Helsinki]", java.time.format.DateTimeFormatter.ISO_ZONED_DATE_TIME.withZone(java.time.ZoneId.systemDefault()));

  public static final String SERIALIZED_NAME_CREATED_BY = "CreatedBy";
  @SerializedName(SERIALIZED_NAME_CREATED_BY)
  private AbstractLong createdBy;

  public static final String SERIALIZED_NAME_CREATED_ON = "CreatedOn";
  @SerializedName(SERIALIZED_NAME_CREATED_ON)
  private OffsetDateTime createdOn = OffsetDateTime.parse("1900-01-01T01:39:49+01:39:49[Europe/Helsinki]", java.time.format.DateTimeFormatter.ISO_ZONED_DATE_TIME.withZone(java.time.ZoneId.systemDefault()));

  public Config() {
  }

  public Config id(String id) {
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


  public Config webhookEntityId(AbstractText webhookEntityId) {
    this.webhookEntityId = webhookEntityId;
    return this;
  }

   /**
   * Get webhookEntityId
   * @return webhookEntityId
  **/
  @javax.annotation.Nonnull
  public AbstractText getWebhookEntityId() {
    return webhookEntityId;
  }

  public void setWebhookEntityId(AbstractText webhookEntityId) {
    this.webhookEntityId = webhookEntityId;
  }


  public Config hasCreateAccess(Boolean hasCreateAccess) {
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


  public Config hasUpdateAccess(Boolean hasUpdateAccess) {
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


  public Config hasDeleteAccess(Boolean hasDeleteAccess) {
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


  public Config isActive(Boolean isActive) {
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


  public Config modifiedBy(AbstractLong modifiedBy) {
    this.modifiedBy = modifiedBy;
    return this;
  }

   /**
   * Get modifiedBy
   * @return modifiedBy
  **/
  @javax.annotation.Nullable
  public AbstractLong getModifiedBy() {
    return modifiedBy;
  }

  public void setModifiedBy(AbstractLong modifiedBy) {
    this.modifiedBy = modifiedBy;
  }


  public Config modifiedOn(OffsetDateTime modifiedOn) {
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


  public Config createdBy(AbstractLong createdBy) {
    this.createdBy = createdBy;
    return this;
  }

   /**
   * Get createdBy
   * @return createdBy
  **/
  @javax.annotation.Nullable
  public AbstractLong getCreatedBy() {
    return createdBy;
  }

  public void setCreatedBy(AbstractLong createdBy) {
    this.createdBy = createdBy;
  }


  public Config createdOn(OffsetDateTime createdOn) {
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
    Config config = (Config) o;
    return Objects.equals(this.id, config.id) &&
        Objects.equals(this.webhookEntityId, config.webhookEntityId) &&
        Objects.equals(this.hasCreateAccess, config.hasCreateAccess) &&
        Objects.equals(this.hasUpdateAccess, config.hasUpdateAccess) &&
        Objects.equals(this.hasDeleteAccess, config.hasDeleteAccess) &&
        Objects.equals(this.isActive, config.isActive) &&
        Objects.equals(this.modifiedBy, config.modifiedBy) &&
        Objects.equals(this.modifiedOn, config.modifiedOn) &&
        Objects.equals(this.createdBy, config.createdBy) &&
        Objects.equals(this.createdOn, config.createdOn);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, webhookEntityId, hasCreateAccess, hasUpdateAccess, hasDeleteAccess, isActive, modifiedBy, modifiedOn, createdBy, createdOn);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Config {\n");
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
  * @throws IOException if the JSON Element is invalid with respect to Config
  */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!Config.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in Config is not found in the empty JSON string", Config.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!Config.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `Config` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : Config.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if (!jsonObj.get("Id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `Id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("Id").toString()));
      }
      // validate the required field `WebhookEntityId`
      AbstractText.validateJsonElement(jsonObj.get("WebhookEntityId"));
      // validate the optional field `ModifiedBy`
      if (jsonObj.get("ModifiedBy") != null && !jsonObj.get("ModifiedBy").isJsonNull()) {
        AbstractLong.validateJsonElement(jsonObj.get("ModifiedBy"));
      }
      // validate the optional field `CreatedBy`
      if (jsonObj.get("CreatedBy") != null && !jsonObj.get("CreatedBy").isJsonNull()) {
        AbstractLong.validateJsonElement(jsonObj.get("CreatedBy"));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!Config.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'Config' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<Config> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(Config.class));

       return (TypeAdapter<T>) new TypeAdapter<Config>() {
           @Override
           public void write(JsonWriter out, Config value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public Config read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of Config given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of Config
  * @throws IOException if the JSON string is invalid with respect to Config
  */
  public static Config fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, Config.class);
  }

 /**
  * Convert an instance of Config to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}
