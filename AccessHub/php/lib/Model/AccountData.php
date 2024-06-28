<?php
/**
 * AccountData
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
 * AccountData Class Doc Comment
 *
 * @category Class
 * @description The record of Account information.
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<string, mixed>
 */
class AccountData implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'AccountData';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'id' => 'string',
        'tenant_id' => '\OpenAPI\Client\Model\FieldType',
        'name' => 'string',
        'first_name' => 'string',
        'last_name' => 'string',
        'phone' => 'string',
        'email' => 'string',
        'language_id' => '\OpenAPI\Client\Model\FieldType',
        'timezone_id' => '\OpenAPI\Client\Model\FieldType',
        'date_format_id' => '\OpenAPI\Client\Model\FieldType',
        'username' => 'string',
        'external_id' => 'string',
        'notify_by_email' => 'bool',
        'notify_by_sms' => 'bool',
        'is_active' => 'bool',
        'modified_on' => '\DateTime',
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
        'tenant_id' => null,
        'name' => null,
        'first_name' => null,
        'last_name' => null,
        'phone' => null,
        'email' => null,
        'language_id' => null,
        'timezone_id' => null,
        'date_format_id' => null,
        'username' => null,
        'external_id' => null,
        'notify_by_email' => null,
        'notify_by_sms' => null,
        'is_active' => null,
        'modified_on' => 'date-time',
        'created_on' => 'date-time'
    ];

    /**
      * Array of nullable properties. Used for (de)serialization
      *
      * @var boolean[]
      */
    protected static array $openAPINullables = [
        'id' => false,
        'tenant_id' => false,
        'name' => false,
        'first_name' => false,
        'last_name' => false,
        'phone' => false,
        'email' => false,
        'language_id' => false,
        'timezone_id' => false,
        'date_format_id' => false,
        'username' => false,
        'external_id' => false,
        'notify_by_email' => false,
        'notify_by_sms' => false,
        'is_active' => false,
        'modified_on' => false,
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
        'tenant_id' => 'TenantId',
        'name' => 'Name',
        'first_name' => 'FirstName',
        'last_name' => 'LastName',
        'phone' => 'Phone',
        'email' => 'Email',
        'language_id' => 'LanguageId',
        'timezone_id' => 'TimezoneId',
        'date_format_id' => 'DateFormatId',
        'username' => 'Username',
        'external_id' => 'ExternalId',
        'notify_by_email' => 'NotifyByEmail',
        'notify_by_sms' => 'NotifyBySMS',
        'is_active' => 'Is_Active',
        'modified_on' => 'ModifiedOn',
        'created_on' => 'CreatedOn'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
        'tenant_id' => 'setTenantId',
        'name' => 'setName',
        'first_name' => 'setFirstName',
        'last_name' => 'setLastName',
        'phone' => 'setPhone',
        'email' => 'setEmail',
        'language_id' => 'setLanguageId',
        'timezone_id' => 'setTimezoneId',
        'date_format_id' => 'setDateFormatId',
        'username' => 'setUsername',
        'external_id' => 'setExternalId',
        'notify_by_email' => 'setNotifyByEmail',
        'notify_by_sms' => 'setNotifyBySms',
        'is_active' => 'setIsActive',
        'modified_on' => 'setModifiedOn',
        'created_on' => 'setCreatedOn'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
        'tenant_id' => 'getTenantId',
        'name' => 'getName',
        'first_name' => 'getFirstName',
        'last_name' => 'getLastName',
        'phone' => 'getPhone',
        'email' => 'getEmail',
        'language_id' => 'getLanguageId',
        'timezone_id' => 'getTimezoneId',
        'date_format_id' => 'getDateFormatId',
        'username' => 'getUsername',
        'external_id' => 'getExternalId',
        'notify_by_email' => 'getNotifyByEmail',
        'notify_by_sms' => 'getNotifyBySms',
        'is_active' => 'getIsActive',
        'modified_on' => 'getModifiedOn',
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
        $this->setIfExists('tenant_id', $data ?? [], null);
        $this->setIfExists('name', $data ?? [], null);
        $this->setIfExists('first_name', $data ?? [], null);
        $this->setIfExists('last_name', $data ?? [], null);
        $this->setIfExists('phone', $data ?? [], null);
        $this->setIfExists('email', $data ?? [], null);
        $this->setIfExists('language_id', $data ?? [], null);
        $this->setIfExists('timezone_id', $data ?? [], null);
        $this->setIfExists('date_format_id', $data ?? [], null);
        $this->setIfExists('username', $data ?? [], null);
        $this->setIfExists('external_id', $data ?? [], null);
        $this->setIfExists('notify_by_email', $data ?? [], false);
        $this->setIfExists('notify_by_sms', $data ?? [], false);
        $this->setIfExists('is_active', $data ?? [], false);
        $this->setIfExists('modified_on', $data ?? [], null);
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
        if ($this->container['first_name'] === null) {
            $invalidProperties[] = "'first_name' can't be null";
        }
        if ($this->container['last_name'] === null) {
            $invalidProperties[] = "'last_name' can't be null";
        }
        if ($this->container['email'] === null) {
            $invalidProperties[] = "'email' can't be null";
        }
        if ($this->container['username'] === null) {
            $invalidProperties[] = "'username' can't be null";
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
     * @param string $id The identifier of account
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
     * Gets tenant_id
     *
     * @return \OpenAPI\Client\Model\FieldType|null
     */
    public function getTenantId()
    {
        return $this->container['tenant_id'];
    }

    /**
     * Sets tenant_id
     *
     * @param \OpenAPI\Client\Model\FieldType|null $tenant_id tenant_id
     *
     * @return self
     */
    public function setTenantId($tenant_id)
    {
        if (is_null($tenant_id)) {
            throw new \InvalidArgumentException('non-nullable tenant_id cannot be null');
        }
        $this->container['tenant_id'] = $tenant_id;

        return $this;
    }

    /**
     * Gets name
     *
     * @return string|null
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     *
     * @param string|null $name The name of the account
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
     * Gets first_name
     *
     * @return string
     */
    public function getFirstName()
    {
        return $this->container['first_name'];
    }

    /**
     * Sets first_name
     *
     * @param string $first_name Person's first name
     *
     * @return self
     */
    public function setFirstName($first_name)
    {
        if (is_null($first_name)) {
            throw new \InvalidArgumentException('non-nullable first_name cannot be null');
        }
        $this->container['first_name'] = $first_name;

        return $this;
    }

    /**
     * Gets last_name
     *
     * @return string
     */
    public function getLastName()
    {
        return $this->container['last_name'];
    }

    /**
     * Sets last_name
     *
     * @param string $last_name Person's last name
     *
     * @return self
     */
    public function setLastName($last_name)
    {
        if (is_null($last_name)) {
            throw new \InvalidArgumentException('non-nullable last_name cannot be null');
        }
        $this->container['last_name'] = $last_name;

        return $this;
    }

    /**
     * Gets phone
     *
     * @return string|null
     */
    public function getPhone()
    {
        return $this->container['phone'];
    }

    /**
     * Sets phone
     *
     * @param string|null $phone The phone number of account. The phone number is unique in the system
     *
     * @return self
     */
    public function setPhone($phone)
    {
        if (is_null($phone)) {
            throw new \InvalidArgumentException('non-nullable phone cannot be null');
        }
        $this->container['phone'] = $phone;

        return $this;
    }

    /**
     * Gets email
     *
     * @return string
     */
    public function getEmail()
    {
        return $this->container['email'];
    }

    /**
     * Sets email
     *
     * @param string $email The e-mail of account. The email is unique in the system
     *
     * @return self
     */
    public function setEmail($email)
    {
        if (is_null($email)) {
            throw new \InvalidArgumentException('non-nullable email cannot be null');
        }
        $this->container['email'] = $email;

        return $this;
    }

    /**
     * Gets language_id
     *
     * @return \OpenAPI\Client\Model\FieldType|null
     */
    public function getLanguageId()
    {
        return $this->container['language_id'];
    }

    /**
     * Sets language_id
     *
     * @param \OpenAPI\Client\Model\FieldType|null $language_id language_id
     *
     * @return self
     */
    public function setLanguageId($language_id)
    {
        if (is_null($language_id)) {
            throw new \InvalidArgumentException('non-nullable language_id cannot be null');
        }
        $this->container['language_id'] = $language_id;

        return $this;
    }

    /**
     * Gets timezone_id
     *
     * @return \OpenAPI\Client\Model\FieldType|null
     */
    public function getTimezoneId()
    {
        return $this->container['timezone_id'];
    }

    /**
     * Sets timezone_id
     *
     * @param \OpenAPI\Client\Model\FieldType|null $timezone_id timezone_id
     *
     * @return self
     */
    public function setTimezoneId($timezone_id)
    {
        if (is_null($timezone_id)) {
            throw new \InvalidArgumentException('non-nullable timezone_id cannot be null');
        }
        $this->container['timezone_id'] = $timezone_id;

        return $this;
    }

    /**
     * Gets date_format_id
     *
     * @return \OpenAPI\Client\Model\FieldType|null
     */
    public function getDateFormatId()
    {
        return $this->container['date_format_id'];
    }

    /**
     * Sets date_format_id
     *
     * @param \OpenAPI\Client\Model\FieldType|null $date_format_id date_format_id
     *
     * @return self
     */
    public function setDateFormatId($date_format_id)
    {
        if (is_null($date_format_id)) {
            throw new \InvalidArgumentException('non-nullable date_format_id cannot be null');
        }
        $this->container['date_format_id'] = $date_format_id;

        return $this;
    }

    /**
     * Gets username
     *
     * @return string
     */
    public function getUsername()
    {
        return $this->container['username'];
    }

    /**
     * Sets username
     *
     * @param string $username Username used to log in into the system. The username is unique in the system
     *
     * @return self
     */
    public function setUsername($username)
    {
        if (is_null($username)) {
            throw new \InvalidArgumentException('non-nullable username cannot be null');
        }
        $this->container['username'] = $username;

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
     * @param string|null $external_id External Authentication identifier. Example Azure AD guid
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
     * Gets notify_by_email
     *
     * @return bool|null
     */
    public function getNotifyByEmail()
    {
        return $this->container['notify_by_email'];
    }

    /**
     * Sets notify_by_email
     *
     * @param bool|null $notify_by_email Defines if a person should get notifications via e-mail
     *
     * @return self
     */
    public function setNotifyByEmail($notify_by_email)
    {
        if (is_null($notify_by_email)) {
            throw new \InvalidArgumentException('non-nullable notify_by_email cannot be null');
        }
        $this->container['notify_by_email'] = $notify_by_email;

        return $this;
    }

    /**
     * Gets notify_by_sms
     *
     * @return bool|null
     */
    public function getNotifyBySms()
    {
        return $this->container['notify_by_sms'];
    }

    /**
     * Sets notify_by_sms
     *
     * @param bool|null $notify_by_sms Defines if a contact should get notifications via SMS
     *
     * @return self
     */
    public function setNotifyBySms($notify_by_sms)
    {
        if (is_null($notify_by_sms)) {
            throw new \InvalidArgumentException('non-nullable notify_by_sms cannot be null');
        }
        $this->container['notify_by_sms'] = $notify_by_sms;

        return $this;
    }

    /**
     * Gets is_active
     *
     * @return bool|null
     */
    public function getIsActive()
    {
        return $this->container['is_active'];
    }

    /**
     * Sets is_active
     *
     * @param bool|null $is_active Defines if the account is active and can be used
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


