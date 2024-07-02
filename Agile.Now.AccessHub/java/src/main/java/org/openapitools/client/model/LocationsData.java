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
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import org.openapitools.client.model.ListValidation;
import org.openapitools.client.model.LocationText;

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
 * The data loading record of Location importing
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-07-01T14:05:01.090617400+03:00[Europe/Helsinki]", comments = "Generator version: 7.6.0")
public class LocationsData {
  public static final String SERIALIZED_NAME_EXTRA = "Extra";
  @SerializedName(SERIALIZED_NAME_EXTRA)
  private List<ListValidation> extra = new ArrayList<>();

  public static final String SERIALIZED_NAME_IS_FULL_VALIDATION = "IsFullValidation";
  @SerializedName(SERIALIZED_NAME_IS_FULL_VALIDATION)
  private Boolean isFullValidation = false;

  public static final String SERIALIZED_NAME_LOCATIONS = "Locations";
  @SerializedName(SERIALIZED_NAME_LOCATIONS)
  private List<LocationText> locations = new ArrayList<>();

  public LocationsData() {
  }

  public LocationsData extra(List<ListValidation> extra) {
    this.extra = extra;
    return this;
  }

  public LocationsData addExtraItem(ListValidation extraItem) {
    if (this.extra == null) {
      this.extra = new ArrayList<>();
    }
    this.extra.add(extraItem);
    return this;
  }

   /**
   * List validation for entity attribute
   * @return extra
  **/
  @javax.annotation.Nullable
  public List<ListValidation> getExtra() {
    return extra;
  }

  public void setExtra(List<ListValidation> extra) {
    this.extra = extra;
  }


  public LocationsData isFullValidation(Boolean isFullValidation) {
    this.isFullValidation = isFullValidation;
    return this;
  }

   /**
   * If the value is true, the data quality of all fields are checked. This has an effect on performance.
   * @return isFullValidation
  **/
  @javax.annotation.Nullable
  public Boolean getIsFullValidation() {
    return isFullValidation;
  }

  public void setIsFullValidation(Boolean isFullValidation) {
    this.isFullValidation = isFullValidation;
  }


  public LocationsData locations(List<LocationText> locations) {
    this.locations = locations;
    return this;
  }

  public LocationsData addLocationsItem(LocationText locationsItem) {
    if (this.locations == null) {
      this.locations = new ArrayList<>();
    }
    this.locations.add(locationsItem);
    return this;
  }

   /**
   * The list of &#x60;Location&#x60; data record for import
   * @return locations
  **/
  @javax.annotation.Nullable
  public List<LocationText> getLocations() {
    return locations;
  }

  public void setLocations(List<LocationText> locations) {
    this.locations = locations;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LocationsData locationsData = (LocationsData) o;
    return Objects.equals(this.extra, locationsData.extra) &&
        Objects.equals(this.isFullValidation, locationsData.isFullValidation) &&
        Objects.equals(this.locations, locationsData.locations);
  }

  @Override
  public int hashCode() {
    return Objects.hash(extra, isFullValidation, locations);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LocationsData {\n");
    sb.append("    extra: ").append(toIndentedString(extra)).append("\n");
    sb.append("    isFullValidation: ").append(toIndentedString(isFullValidation)).append("\n");
    sb.append("    locations: ").append(toIndentedString(locations)).append("\n");
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
    openapiFields.add("Extra");
    openapiFields.add("IsFullValidation");
    openapiFields.add("Locations");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Element and throws an exception if issues found
  *
  * @param jsonElement JSON Element
  * @throws IOException if the JSON Element is invalid with respect to LocationsData
  */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!LocationsData.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in LocationsData is not found in the empty JSON string", LocationsData.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!LocationsData.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `LocationsData` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if (jsonObj.get("Extra") != null && !jsonObj.get("Extra").isJsonNull()) {
        JsonArray jsonArrayextra = jsonObj.getAsJsonArray("Extra");
        if (jsonArrayextra != null) {
          // ensure the json data is an array
          if (!jsonObj.get("Extra").isJsonArray()) {
            throw new IllegalArgumentException(String.format("Expected the field `Extra` to be an array in the JSON string but got `%s`", jsonObj.get("Extra").toString()));
          }

          // validate the optional field `Extra` (array)
          for (int i = 0; i < jsonArrayextra.size(); i++) {
            ListValidation.validateJsonElement(jsonArrayextra.get(i));
          };
        }
      }
      if (jsonObj.get("Locations") != null && !jsonObj.get("Locations").isJsonNull()) {
        JsonArray jsonArraylocations = jsonObj.getAsJsonArray("Locations");
        if (jsonArraylocations != null) {
          // ensure the json data is an array
          if (!jsonObj.get("Locations").isJsonArray()) {
            throw new IllegalArgumentException(String.format("Expected the field `Locations` to be an array in the JSON string but got `%s`", jsonObj.get("Locations").toString()));
          }

          // validate the optional field `Locations` (array)
          for (int i = 0; i < jsonArraylocations.size(); i++) {
            LocationText.validateJsonElement(jsonArraylocations.get(i));
          };
        }
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!LocationsData.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'LocationsData' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<LocationsData> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(LocationsData.class));

       return (TypeAdapter<T>) new TypeAdapter<LocationsData>() {
           @Override
           public void write(JsonWriter out, LocationsData value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public LocationsData read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of LocationsData given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of LocationsData
  * @throws IOException if the JSON string is invalid with respect to LocationsData
  */
  public static LocationsData fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, LocationsData.class);
  }

 /**
  * Convert an instance of LocationsData to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}
