<?php
/**
 * DepartmentText
 *
 * PHP version 7.4
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.20
 * Generated by: https://openapi-generator.tech
 * Generator version: 7.6.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Model;

use \ArrayAccess;
use \OpenAPI\Client\ObjectSerializer;

/**
 * DepartmentText Class Doc Comment
 *
 * @category Class
 * @description The record of Department information.
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<string, mixed>
 */
class DepartmentText implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'DepartmentText';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'id' => 'string',
        'external_id' => 'string',
        'name' => 'string',
        'department_type_id' => 'string',
        'parent_department_id' => 'string',
        'hierarchical_name' => 'string',
        'level' => 'int',
        'contact_name' => 'string',
        'contact_email' => 'string',
        'contact_phone' => 'string',
        'owner_id' => 'string',
        'country_id' => 'string',
        'is_active' => 'bool',
        'modified_on' => '\DateTime',
        'modified_by' => 'string',
        'created_by' => 'string',
        'created_on' => '\DateTime'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'id' => null,
        'external_id' => null,
        'name' => null,
        'department_type_id' => null,
        'parent_department_id' => null,
        'hierarchical_name' => null,
        'level' => 'int32',
        'contact_name' => null,
        'contact_email' => null,
        'contact_phone' => null,
        'owner_id' => null,
        'country_id' => null,
        'is_active' => null,
        'modified_on' => 'date-time',
        'modified_by' => null,
        'created_by' => null,
        'created_on' => 'date-time'
    ];

    /**
      * Array of nullable properties. Used for (de)serialization
      *
      * @var boolean[]
      */
    protected static array $openAPINullables = [
        'id' => false,
        'external_id' => false,
        'name' => false,
        'department_type_id' => false,
        'parent_department_id' => false,
        'hierarchical_name' => false,
        'level' => false,
        'contact_name' => false,
        'contact_email' => false,
        'contact_phone' => false,
        'owner_id' => false,
        'country_id' => false,
        'is_active' => false,
        'modified_on' => false,
        'modified_by' => false,
        'created_by' => false,
        'created_on' => false
    ];

    /**
      * If a nullable field gets set to null, insert it here
      *
      * @var boolean[]
      */
    protected array $openAPINullablesSetToNull = [];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of nullable properties
     *
     * @return array
     */
    protected static function openAPINullables(): array
    {
        return self::$openAPINullables;
    }

    /**
     * Array of nullable field names deliberately set to null
     *
     * @return boolean[]
     */
    private function getOpenAPINullablesSetToNull(): array
    {
        return $this->openAPINullablesSetToNull;
    }

    /**
     * Setter - Array of nullable field names deliberately set to null
     *
     * @param boolean[] $openAPINullablesSetToNull
     */
    private function setOpenAPINullablesSetToNull(array $openAPINullablesSetToNull): void
    {
        $this->openAPINullablesSetToNull = $openAPINullablesSetToNull;
    }

    /**
     * Checks if a property is nullable
     *
     * @param string $property
     * @return bool
     */
    public static function isNullable(string $property): bool
    {
        return self::openAPINullables()[$property] ?? false;
    }

    /**
     * Checks if a nullable property is set to null.
     *
     * @param string $property
     * @return bool
     */
    public function isNullableSetToNull(string $property): bool
    {
        return in_array($property, $this->getOpenAPINullablesSetToNull(), true);
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'id' => 'Id',
        'external_id' => 'ExternalId',
        'name' => 'Name',
        'department_type_id' => 'DepartmentTypeId',
        'parent_department_id' => 'ParentDepartmentId',
        'hierarchical_name' => 'HierarchicalName',
        'level' => 'Level',
        'contact_name' => 'ContactName',
        'contact_email' => 'ContactEmail',
        'contact_phone' => 'ContactPhone',
        'owner_id' => 'OwnerId',
        'country_id' => 'CountryId',
        'is_active' => 'Is_Active',
        'modified_on' => 'ModifiedOn',
        'modified_by' => 'ModifiedBy',
        'created_by' => 'CreatedBy',
        'created_on' => 'CreatedOn'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
        'external_id' => 'setExternalId',
        'name' => 'setName',
        'department_type_id' => 'setDepartmentTypeId',
        'parent_department_id' => 'setParentDepartmentId',
        'hierarchical_name' => 'setHierarchicalName',
        'level' => 'setLevel',
        'contact_name' => 'setContactName',
        'contact_email' => 'setContactEmail',
        'contact_phone' => 'setContactPhone',
        'owner_id' => 'setOwnerId',
        'country_id' => 'setCountryId',
        'is_active' => 'setIsActive',
        'modified_on' => 'setModifiedOn',
        'modified_by' => 'setModifiedBy',
        'created_by' => 'setCreatedBy',
        'created_on' => 'setCreatedOn'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
        'external_id' => 'getExternalId',
        'name' => 'getName',
        'department_type_id' => 'getDepartmentTypeId',
        'parent_department_id' => 'getParentDepartmentId',
        'hierarchical_name' => 'getHierarchicalName',
        'level' => 'getLevel',
        'contact_name' => 'getContactName',
        'contact_email' => 'getContactEmail',
        'contact_phone' => 'getContactPhone',
        'owner_id' => 'getOwnerId',
        'country_id' => 'getCountryId',
        'is_active' => 'getIsActive',
        'modified_on' => 'getModifiedOn',
        'modified_by' => 'getModifiedBy',
        'created_by' => 'getCreatedBy',
        'created_on' => 'getCreatedOn'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }


    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->setIfExists('id', $data ?? [], null);
        $this->setIfExists('external_id', $data ?? [], null);
        $this->setIfExists('name', $data ?? [], null);
        $this->setIfExists('department_type_id', $data ?? [], null);
        $this->setIfExists('parent_department_id', $data ?? [], null);
        $this->setIfExists('hierarchical_name', $data ?? [], null);
        $this->setIfExists('level', $data ?? [], 0);
        $this->setIfExists('contact_name', $data ?? [], null);
        $this->setIfExists('contact_email', $data ?? [], null);
        $this->setIfExists('contact_phone', $data ?? [], null);
        $this->setIfExists('owner_id', $data ?? [], null);
        $this->setIfExists('country_id', $data ?? [], null);
        $this->setIfExists('is_active', $data ?? [], false);
        $this->setIfExists('modified_on', $data ?? [], null);
        $this->setIfExists('modified_by', $data ?? [], null);
        $this->setIfExists('created_by', $data ?? [], null);
        $this->setIfExists('created_on', $data ?? [], null);
    }

    /**
    * Sets $this->container[$variableName] to the given data or to the given default Value; if $variableName
    * is nullable and its value is set to null in the $fields array, then mark it as "set to null" in the
    * $this->openAPINullablesSetToNull array
    *
    * @param string $variableName
    * @param array  $fields
    * @param mixed  $defaultValue
    */
    private function setIfExists(string $variableName, array $fields, $defaultValue): void
    {
        if (self::isNullable($variableName) && array_key_exists($variableName, $fields) && is_null($fields[$variableName])) {
            $this->openAPINullablesSetToNull[] = $variableName;
        }

        $this->container[$variableName] = $fields[$variableName] ?? $defaultValue;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['id'] === null) {
            $invalidProperties[] = "'id' can't be null";
        }
        if ($this->container['name'] === null) {
            $invalidProperties[] = "'name' can't be null";
        }
        if ($this->container['department_type_id'] === null) {
            $invalidProperties[] = "'department_type_id' can't be null";
        }
        if ($this->container['is_active'] === null) {
            $invalidProperties[] = "'is_active' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets id
     *
     * @return string
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     *
     * @param string $id The guid to identify the department
     *
     * @return self
     */
    public function setId($id)
    {
        if (is_null($id)) {
            throw new \InvalidArgumentException('non-nullable id cannot be null');
        }
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets external_id
     *
     * @return string|null
     */
    public function getExternalId()
    {
        return $this->container['external_id'];
    }

    /**
     * Sets external_id
     *
     * @param string|null $external_id The external identifier of the department
     *
     * @return self
     */
    public function setExternalId($external_id)
    {
        if (is_null($external_id)) {
            throw new \InvalidArgumentException('non-nullable external_id cannot be null');
        }
        $this->container['external_id'] = $external_id;

        return $this;
    }

    /**
     * Gets name
     *
     * @return string
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     *
     * @param string $name The name of the department
     *
     * @return self
     */
    public function setName($name)
    {
        if (is_null($name)) {
            throw new \InvalidArgumentException('non-nullable name cannot be null');
        }
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets department_type_id
     *
     * @return string
     */
    public function getDepartmentTypeId()
    {
        return $this->container['department_type_id'];
    }

    /**
     * Sets department_type_id
     *
     * @param string $department_type_id The  type of department
     *
     * @return self
     */
    public function setDepartmentTypeId($department_type_id)
    {
        if (is_null($department_type_id)) {
            throw new \InvalidArgumentException('non-nullable department_type_id cannot be null');
        }
        $this->container['department_type_id'] = $department_type_id;

        return $this;
    }

    /**
     * Gets parent_department_id
     *
     * @return string|null
     */
    public function getParentDepartmentId()
    {
        return $this->container['parent_department_id'];
    }

    /**
     * Sets parent_department_id
     *
     * @param string|null $parent_department_id The identifier of the parent department
     *
     * @return self
     */
    public function setParentDepartmentId($parent_department_id)
    {
        if (is_null($parent_department_id)) {
            throw new \InvalidArgumentException('non-nullable parent_department_id cannot be null');
        }
        $this->container['parent_department_id'] = $parent_department_id;

        return $this;
    }

    /**
     * Gets hierarchical_name
     *
     * @return string|null
     */
    public function getHierarchicalName()
    {
        return $this->container['hierarchical_name'];
    }

    /**
     * Sets hierarchical_name
     *
     * @param string|null $hierarchical_name The hierarchical name of the department
     *
     * @return self
     */
    public function setHierarchicalName($hierarchical_name)
    {
        if (is_null($hierarchical_name)) {
            throw new \InvalidArgumentException('non-nullable hierarchical_name cannot be null');
        }
        $this->container['hierarchical_name'] = $hierarchical_name;

        return $this;
    }

    /**
     * Gets level
     *
     * @return int|null
     */
    public function getLevel()
    {
        return $this->container['level'];
    }

    /**
     * Sets level
     *
     * @param int|null $level The department level at the hierarchy
     *
     * @return self
     */
    public function setLevel($level)
    {
        if (is_null($level)) {
            throw new \InvalidArgumentException('non-nullable level cannot be null');
        }
        $this->container['level'] = $level;

        return $this;
    }

    /**
     * Gets contact_name
     *
     * @return string|null
     */
    public function getContactName()
    {
        return $this->container['contact_name'];
    }

    /**
     * Sets contact_name
     *
     * @param string|null $contact_name The contact name of company or department
     *
     * @return self
     */
    public function setContactName($contact_name)
    {
        if (is_null($contact_name)) {
            throw new \InvalidArgumentException('non-nullable contact_name cannot be null');
        }
        $this->container['contact_name'] = $contact_name;

        return $this;
    }

    /**
     * Gets contact_email
     *
     * @return string|null
     */
    public function getContactEmail()
    {
        return $this->container['contact_email'];
    }

    /**
     * Sets contact_email
     *
     * @param string|null $contact_email The contact email of external company or department
     *
     * @return self
     */
    public function setContactEmail($contact_email)
    {
        if (is_null($contact_email)) {
            throw new \InvalidArgumentException('non-nullable contact_email cannot be null');
        }
        $this->container['contact_email'] = $contact_email;

        return $this;
    }

    /**
     * Gets contact_phone
     *
     * @return string|null
     */
    public function getContactPhone()
    {
        return $this->container['contact_phone'];
    }

    /**
     * Sets contact_phone
     *
     * @param string|null $contact_phone contact_phone
     *
     * @return self
     */
    public function setContactPhone($contact_phone)
    {
        if (is_null($contact_phone)) {
            throw new \InvalidArgumentException('non-nullable contact_phone cannot be null');
        }
        $this->container['contact_phone'] = $contact_phone;

        return $this;
    }

    /**
     * Gets owner_id
     *
     * @return string|null
     */
    public function getOwnerId()
    {
        return $this->container['owner_id'];
    }

    /**
     * Sets owner_id
     *
     * @param string|null $owner_id The identifier of the user who own the department
     *
     * @return self
     */
    public function setOwnerId($owner_id)
    {
        if (is_null($owner_id)) {
            throw new \InvalidArgumentException('non-nullable owner_id cannot be null');
        }
        $this->container['owner_id'] = $owner_id;

        return $this;
    }

    /**
     * Gets country_id
     *
     * @return string|null
     */
    public function getCountryId()
    {
        return $this->container['country_id'];
    }

    /**
     * Sets country_id
     *
     * @param string|null $country_id The country of the department
     *
     * @return self
     */
    public function setCountryId($country_id)
    {
        if (is_null($country_id)) {
            throw new \InvalidArgumentException('non-nullable country_id cannot be null');
        }
        $this->container['country_id'] = $country_id;

        return $this;
    }

    /**
     * Gets is_active
     *
     * @return bool
     */
    public function getIsActive()
    {
        return $this->container['is_active'];
    }

    /**
     * Sets is_active
     *
     * @param bool $is_active Defines if the department is active and can be used
     *
     * @return self
     */
    public function setIsActive($is_active)
    {
        if (is_null($is_active)) {
            throw new \InvalidArgumentException('non-nullable is_active cannot be null');
        }
        $this->container['is_active'] = $is_active;

        return $this;
    }

    /**
     * Gets modified_on
     *
     * @return \DateTime|null
     */
    public function getModifiedOn()
    {
        return $this->container['modified_on'];
    }

    /**
     * Sets modified_on
     *
     * @param \DateTime|null $modified_on The date the record was updated
     *
     * @return self
     */
    public function setModifiedOn($modified_on)
    {
        if (is_null($modified_on)) {
            throw new \InvalidArgumentException('non-nullable modified_on cannot be null');
        }
        $this->container['modified_on'] = $modified_on;

        return $this;
    }

    /**
     * Gets modified_by
     *
     * @return string|null
     */
    public function getModifiedBy()
    {
        return $this->container['modified_by'];
    }

    /**
     * Sets modified_by
     *
     * @param string|null $modified_by The Identifier of the user who updated the record
     *
     * @return self
     */
    public function setModifiedBy($modified_by)
    {
        if (is_null($modified_by)) {
            throw new \InvalidArgumentException('non-nullable modified_by cannot be null');
        }
        $this->container['modified_by'] = $modified_by;

        return $this;
    }

    /**
     * Gets created_by
     *
     * @return string|null
     */
    public function getCreatedBy()
    {
        return $this->container['created_by'];
    }

    /**
     * Sets created_by
     *
     * @param string|null $created_by The Identifier of the user who created the record
     *
     * @return self
     */
    public function setCreatedBy($created_by)
    {
        if (is_null($created_by)) {
            throw new \InvalidArgumentException('non-nullable created_by cannot be null');
        }
        $this->container['created_by'] = $created_by;

        return $this;
    }

    /**
     * Gets created_on
     *
     * @return \DateTime|null
     */
    public function getCreatedOn()
    {
        return $this->container['created_on'];
    }

    /**
     * Sets created_on
     *
     * @param \DateTime|null $created_on The date the record was created
     *
     * @return self
     */
    public function setCreatedOn($created_on)
    {
        if (is_null($created_on)) {
            throw new \InvalidArgumentException('non-nullable created_on cannot be null');
        }
        $this->container['created_on'] = $created_on;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset): bool
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value): void
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset): void
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    #[\ReturnTypeWillChange]
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


